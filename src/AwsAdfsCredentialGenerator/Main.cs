
namespace AwsAdfsCredentialGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Security.Cryptography;
    using System.Security.Principal;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Xml.Linq;
    using Amazon.Runtime;
    using Amazon.SecurityToken;
    using Amazon.SecurityToken.Model;
    using AngleSharp.Dom.Html;
    using AngleSharp.Parser.Html;
    using AwsAdfsCredentialGenerator.Properties;
    using Microsoft.Win32;

    public partial class Main : Form
    {
        private int _secondsToWait = 3000; // 50 mins (aws STS token freshness is limited to 1 hour
        private DateTime _startTime;

        private static readonly string StartupKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
        private static readonly string StartupValue = "AwsAdfsCredentialGenerator";
        private readonly SortedSet<Profile> _profiles = new SortedSet<Profile>();

        public Main()
        {
            InitializeComponent();
            var link = new LinkLabel.Link
            {
                LinkData = "https://github.com/damianh/aws-adfs-credential-generator"
            };
            projectLinkLabel.Links.Add(link);

            var userDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            credentialFilePathTextBox.Text = $@"{userDir}\.aws\credentials-generated";

            var myIcon = new Icon(Resources.error, 16, 16);
            pictureBox1.Image = myIcon.ToBitmap();

            useCurrentUserCheckBox.Text += $@" ({WindowsIdentity.GetCurrent().Name})";

            passwordTextBox.Text = ReadPassword();

            var key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
            var value = key?.GetValue(StartupValue);
            startWithWindowsCheckbox.Checked = value != null;
            Task.Run(async () =>
            {
                await Task.Delay(500);
                RefreshCredentials();
            });
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WindowState = FormWindowState.Normal;
            ShowInTaskbar = true;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                notifyIcon.ShowBalloonTip(3000);
                ShowInTaskbar = false;
            }
        }

        private void refreshCredentialsButton_Click(object _, EventArgs __)
        {
            RefreshCredentials();
        }

        private async void RefreshCredentials()
        {
            if(refreshCredentialsButton.InvokeRequired)
            {
                refreshCredentialsButton.Invoke(new Action(RefreshCredentials));
                return;
            }
            refreshCredentialsButton.Enabled = false;
            logTextBox.Text = string.Empty;
            errorPanel.Visible = false;
            profilesListBox.Items.Clear();
            _profiles.Clear();
            refereshTimer.Stop();
            Action<string> log = m => logTextBox.AppendText($"{DateTime.Now}: {m} {Environment.NewLine}");
            try
            {
                // Authenticate against ADFS with NTLM.
                var endpoint = $"{adfsUrlTextBox.Text}?loginToRp={loginToRPTextBox.Text}";

                var handler = new HttpClientHandler
                {
                    UseCookies = true,
                    AllowAutoRedirect = true,
                    ClientCertificateOptions = ClientCertificateOption.Automatic
                };
                if (useCurrentUserCheckBox.Checked)
                {
                    handler.UseDefaultCredentials = true;
                }
                else
                {
                    handler.Credentials = new NetworkCredential(usernameTextBox.Text, passwordTextBox.Text);
                }
                var client = new HttpClient(handler);
                client.DefaultRequestHeaders.Add("User-Agent",
                    "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; WOW64; Trident/6.0)");
                client.DefaultRequestHeaders.Add("Connection", "Keep-Alive");
                client.DefaultRequestHeaders.ExpectContinue = false;

                log($"Logging in as '{usernameTextBox.Text}'...");
                var response = await client.GetAsync(endpoint);

                string body;

                if (useCurrentUserCheckBox.Checked)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        throw new InvalidOperationException("Authentication failed.");
                    }
                    body = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    if (response.StatusCode != HttpStatusCode.Unauthorized)
                    {
                        throw new InvalidOperationException("Invalid ADFS Url. " +
                                                            $"Visit {endpoint} in your browser to verify.");
                    }

                    // Need to a second time for the Network Credentials to be send.
                    // Don't know why, but it works (and I saw firefox doing same). 
                    response = await client.GetAsync(response.RequestMessage.RequestUri);
                    response.EnsureSuccessStatusCode();
                    body = await response.Content.ReadAsStringAsync();
                }

                // Get the base64 encoded SAML response from the respons body HTML.
                var parser = new HtmlParser();
                var htmlDocument = parser.Parse(body);
                var form = htmlDocument.Forms[0];
                var encodedSamlResponse = ((IHtmlInputElement)form
                    .GetElementsByTagName("input")
                    .SingleOrDefault(e => e.GetAttribute("name") == "SAMLResponse"))?.Value;

                if (encodedSamlResponse == null)
                {
                    throw new InvalidOperationException("Authentication failed. Check username and password." +
                                                        $"Visit {endpoint} in your browser to verify.");
                }

                log("...success.");

                // Extract the status code and Role Attributes from the SAML response.
                var samlResponse = Encoding.UTF8.GetString(Convert.FromBase64String(encodedSamlResponse));
                XNamespace pr = "urn:oasis:names:tc:SAML:2.0:protocol";
                XNamespace ast = "urn:oasis:names:tc:SAML:2.0:assertion";
                var doc = XDocument.Parse(samlResponse);
                var status = doc.Element(pr + "Response").Element(pr + "Status");
                var statusCode = status.Element(pr + "StatusCode").Attribute("Value");
                var statusMessage = status.Element(pr + "StatusMessage");
                log($"SAML Status code: {statusCode}; message: {statusMessage}.");

                var attStatement = doc
                    .Element(pr + "Response")
                    .Element(ast + "Assertion")
                    .Element(ast + "AttributeStatement");
                var roles = attStatement
                    .Elements(ast + "Attribute")
                    .First(a => a.Attribute("Name").Value == "https://aws.amazon.com/SAML/Attributes/Role")
                    .Elements(ast + "AttributeValue")
                    .Select(e => e.Value.Split(',')[1])
                    .ToArray();

                log("ADFS Defined Roles: ");
                foreach (var role in roles)
                {
                    log($"  {role}");
                }

                // For each role, call AWS AssumeRoleWithSAML and thus create 
                // temporary credentials.
                var stsClient = new AmazonSecurityTokenServiceClient(new AnonymousAWSCredentials());
                var assumedRoles = new List<AssumeRoleWithSAMLResponse>();
                foreach (var roleArn in roles)
                {
                    log($"Assuming role {roleArn}...");

                    var arnParts = roleArn.Split(':');
                    var account = arnParts[4];

                    var assumeRoleWithSamlRequest = new AssumeRoleWithSAMLRequest
                    {
                        SAMLAssertion = encodedSamlResponse,
                        PrincipalArn = $"arn:aws:iam::{account}:saml-provider/{samlProviderNameTextBox.Text}",
                        RoleArn = roleArn,
                        DurationSeconds = 3600
                    };

                    try
                    {
                        var assumeRoleWithSamlResponse = await stsClient.AssumeRoleWithSAMLAsync(assumeRoleWithSamlRequest);

                        log($"  AccessKeyId: {assumeRoleWithSamlResponse.Credentials.AccessKeyId}");
                        log($"  SecretAccessKey: {assumeRoleWithSamlResponse.Credentials.SecretAccessKey}");
                        log($"  SessionToken: {assumeRoleWithSamlResponse.Credentials.SessionToken}");
                        log($"  Expires: {assumeRoleWithSamlResponse.Credentials.Expiration}");

                        assumedRoles.Add(assumeRoleWithSamlResponse);
                    }
                    catch (Exception ex)
                    {
                        log(ex.ToString());
                    }
                }

                // Write the temporary credentials to a the credential file (ini format)
                var stringBuilder = new StringBuilder();
                foreach (var assumedRole in assumedRoles)
                {
                    var profile = assumedRole.AssumedRoleUser.Arn.Split(':')[5].Split('/')[1];
                    _profiles.Add(
                        new Profile(
                            profile,
                            assumedRole.Credentials.AccessKeyId,
                            assumedRole.Credentials.SecretAccessKey,
                            assumedRole.Credentials.SessionToken));
                    stringBuilder.AppendLine($"[{profile}]");
                    stringBuilder.AppendLine($"aws_access_key_id={assumedRole.Credentials.AccessKeyId}");
                    stringBuilder.AppendLine($"aws_secret_access_key={assumedRole.Credentials.SecretAccessKey}");
                    stringBuilder.AppendLine($"aws_session_token={assumedRole.Credentials.SessionToken}");
                    stringBuilder.AppendLine();
                }
                foreach(var profile in _profiles)
                {
                    profilesListBox.Items.Add(profile);
                }
                var credentialDirectory = Path.GetDirectoryName(credentialFilePathTextBox.Text);
                Directory.CreateDirectory(credentialDirectory);
                File.WriteAllText(credentialFilePathTextBox.Text, stringBuilder.ToString());
                log($"Credentials written to {credentialFilePathTextBox.Text}");
            }
            catch (Exception ex)
            {
                log(ex.ToString());
                errorPanel.Visible = true;
            }

            refreshCredentialsButton.Enabled = true;
            _startTime = DateTime.Now;
            refereshTimer.Start();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.Default.Save();
        }

        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            var elapsedSeconds = (int)(DateTime.Now - _startTime).TotalSeconds;
            var remainingSeconds = _secondsToWait - elapsedSeconds;

            if (remainingSeconds <= 0)
            {
                // run your function
                refereshTimer.Stop();
                RefreshCredentials();
            }

            var timeSpan = TimeSpan.FromSeconds(remainingSeconds);
            countdownLabel.Text = $@"{timeSpan.Minutes.ToString().PadLeft(2, '0')}:{timeSpan.Seconds.ToString().PadLeft(2, '0')}";
        }

        private void useCurrentUser_CheckedChanged(object sender, EventArgs e)
        {
            usernameTextBox.Enabled = !useCurrentUserCheckBox.Checked;
            passwordTextBox.Enabled = !useCurrentUserCheckBox.Checked;
        }

        private void projectLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/damianh/aws-adfs-credential-generator");
        }

        private void startWithWindowsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(startWithWindowsCheckbox.Checked)
            {
                //Set the application to run at startup
                var key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
                key.SetValue(StartupValue, Application.ExecutablePath);
            }
            else
            {
                var key = Registry.CurrentUser.OpenSubKey(StartupKey, true);
                var value = key?.GetValue(StartupValue);
                if(value != null)
                {
                    key.DeleteValue(StartupValue);
                }
            }
        }

        private static readonly byte[] AditionalEntropy = { 1, 5, 9, 8, 7, 6, 5 };

        private string ReadPassword()
        {
            try
            {
                var password = Settings.Default.Password;
                var encrypted = Convert.FromBase64String(password);
                var bytes = ProtectedData.Unprotect(encrypted, AditionalEntropy, DataProtectionScope.CurrentUser);
                return Encoding.UTF8.GetString(bytes);
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        private void SavePassword()
        {
            try
            {
                var bytes = Encoding.UTF8.GetBytes(passwordTextBox.Text);
                var encrypted = ProtectedData.Protect(bytes, AditionalEntropy, DataProtectionScope.CurrentUser);
                var password = Convert.ToBase64String(encrypted);
                Settings.Default.Password = password;
            }
            catch (CryptographicException)
            { }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            SavePassword();
            Settings.Default.Save();
        }

        private void profilesListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.C && profilesListBox.SelectedItem != null)
            {
                Clipboard.SetText(profilesListBox.SelectedItem.ToString());
            }
        }

        private void profilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnvironmentVariables();
        }

        private void setEnvironmentVariablesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            SetEnvironmentVariables();
        }

        private void SetEnvironmentVariables()
        {
            if (!setEnvironmentVariablesCheckBox.Checked || profilesListBox.SelectedItem == null)
            {
                return;
            }
            var profile = (Profile)profilesListBox.SelectedItem;
            Environment.SetEnvironmentVariable("AWS_ACCESS_KEY_ID", profile.AwsAccessKeyId, EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable("AWS_SECRET_ACCESS_KEY", profile.AwsSecretAccess, EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable("AWS_SESSION_TOKEN", profile.AwsSessionToken, EnvironmentVariableTarget.User);
        }

        private void clearEnvVarsButton_Click(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable("AWS_ACCESS_KEY_ID", null, EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable("AWS_SECRET_ACCESS_KEY", null, EnvironmentVariableTarget.User);
            Environment.SetEnvironmentVariable("AWS_SESSION_TOKEN", null, EnvironmentVariableTarget.User);
            setEnvironmentVariablesCheckBox.Checked = false;
        }
    }
}