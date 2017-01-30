﻿namespace AwsAdfsCredentialGenerator
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.loginToRPTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adfsUrlLabel = new System.Windows.Forms.Label();
            this.adfsUrlTextBox = new System.Windows.Forms.TextBox();
            this.labelProfiles = new System.Windows.Forms.Label();
            this.profilesTextBox = new System.Windows.Forms.TextBox();
            this.credentialFilePathLabel = new System.Windows.Forms.Label();
            this.credentialFilePathTextBox = new System.Windows.Forms.TextBox();
            this.samlProviderNameTextBox = new System.Windows.Forms.TextBox();
            this.samlProviderNameLabel = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.useCurrentUserCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.countdownLabel = new System.Windows.Forms.Label();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.refreshCredentialsButton = new System.Windows.Forms.Button();
            this.logTab = new System.Windows.Forms.TabPage();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.aboutTab = new System.Windows.Forms.TabPage();
            this.projectLinkLabel = new System.Windows.Forms.LinkLabel();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.errorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.logTab.SuspendLayout();
            this.aboutTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.logTab);
            this.tabControl1.Controls.Add(this.aboutTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 375);
            this.tabControl1.TabIndex = 0;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.tableLayoutPanel1);
            this.mainTab.Controls.Add(this.panel1);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Margin = new System.Windows.Forms.Padding(2);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(2);
            this.mainTab.Size = new System.Drawing.Size(543, 349);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.loginToRPTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.adfsUrlLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.adfsUrlTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProfiles, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.profilesTextBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.credentialFilePathLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.credentialFilePathTextBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.samlProviderNameTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.samlProviderNameLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelPassword, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.usernameLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.passwordTextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.useCurrentUserCheckBox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 308);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // loginToRPTextBox
            // 
            this.loginToRPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginToRPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AwsAdfsCredentialGenerator.Properties.Settings.Default, "LoginToRP", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.loginToRPTextBox.Location = new System.Drawing.Point(135, 26);
            this.loginToRPTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.loginToRPTextBox.Name = "loginToRPTextBox";
            this.loginToRPTextBox.Size = new System.Drawing.Size(406, 20);
            this.loginToRPTextBox.TabIndex = 1;
            this.loginToRPTextBox.Text = global::AwsAdfsCredentialGenerator.Properties.Settings.Default.LoginToRP;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login to RP:";
            // 
            // adfsUrlLabel
            // 
            this.adfsUrlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adfsUrlLabel.AutoSize = true;
            this.adfsUrlLabel.Location = new System.Drawing.Point(68, 3);
            this.adfsUrlLabel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.adfsUrlLabel.Name = "adfsUrlLabel";
            this.adfsUrlLabel.Size = new System.Drawing.Size(63, 13);
            this.adfsUrlLabel.TabIndex = 0;
            this.adfsUrlLabel.Text = "ADFS URL:";
            // 
            // adfsUrlTextBox
            // 
            this.adfsUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adfsUrlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AwsAdfsCredentialGenerator.Properties.Settings.Default, "AdfsUrl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adfsUrlTextBox.Location = new System.Drawing.Point(135, 2);
            this.adfsUrlTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.adfsUrlTextBox.Name = "adfsUrlTextBox";
            this.adfsUrlTextBox.Size = new System.Drawing.Size(406, 20);
            this.adfsUrlTextBox.TabIndex = 0;
            this.adfsUrlTextBox.Text = global::AwsAdfsCredentialGenerator.Properties.Settings.Default.AdfsUrl;
            // 
            // labelProfiles
            // 
            this.labelProfiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelProfiles.AutoSize = true;
            this.labelProfiles.Location = new System.Drawing.Point(87, 170);
            this.labelProfiles.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.labelProfiles.Name = "labelProfiles";
            this.labelProfiles.Size = new System.Drawing.Size(44, 13);
            this.labelProfiles.TabIndex = 11;
            this.labelProfiles.Text = "Profiles:";
            // 
            // profilesTextBox
            // 
            this.profilesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profilesTextBox.Location = new System.Drawing.Point(135, 169);
            this.profilesTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilesTextBox.Multiline = true;
            this.profilesTextBox.Name = "profilesTextBox";
            this.profilesTextBox.ReadOnly = true;
            this.profilesTextBox.Size = new System.Drawing.Size(406, 137);
            this.profilesTextBox.TabIndex = 6;
            this.profilesTextBox.UseSystemPasswordChar = true;
            // 
            // credentialFilePathLabel
            // 
            this.credentialFilePathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.credentialFilePathLabel.AutoSize = true;
            this.credentialFilePathLabel.Location = new System.Drawing.Point(30, 146);
            this.credentialFilePathLabel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.credentialFilePathLabel.Name = "credentialFilePathLabel";
            this.credentialFilePathLabel.Size = new System.Drawing.Size(101, 13);
            this.credentialFilePathLabel.TabIndex = 9;
            this.credentialFilePathLabel.Text = "Credential File Path:";
            // 
            // credentialFilePathTextBox
            // 
            this.credentialFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.credentialFilePathTextBox.Location = new System.Drawing.Point(135, 145);
            this.credentialFilePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.credentialFilePathTextBox.Name = "credentialFilePathTextBox";
            this.credentialFilePathTextBox.ReadOnly = true;
            this.credentialFilePathTextBox.Size = new System.Drawing.Size(406, 20);
            this.credentialFilePathTextBox.TabIndex = 5;
            // 
            // samlProviderNameTextBox
            // 
            this.samlProviderNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.samlProviderNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AwsAdfsCredentialGenerator.Properties.Settings.Default, "SamlProviderName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.samlProviderNameTextBox.Location = new System.Drawing.Point(135, 121);
            this.samlProviderNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.samlProviderNameTextBox.Name = "samlProviderNameTextBox";
            this.samlProviderNameTextBox.Size = new System.Drawing.Size(406, 20);
            this.samlProviderNameTextBox.TabIndex = 4;
            this.samlProviderNameTextBox.Text = global::AwsAdfsCredentialGenerator.Properties.Settings.Default.SamlProviderName;
            // 
            // samlProviderNameLabel
            // 
            this.samlProviderNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.samlProviderNameLabel.AutoSize = true;
            this.samlProviderNameLabel.Location = new System.Drawing.Point(19, 122);
            this.samlProviderNameLabel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.samlProviderNameLabel.Name = "samlProviderNameLabel";
            this.samlProviderNameLabel.Size = new System.Drawing.Size(112, 13);
            this.samlProviderNameLabel.TabIndex = 7;
            this.samlProviderNameLabel.Text = "SAML Provider Name:";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(75, 98);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(56, 13);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(73, 74);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.Enabled = false;
            this.passwordTextBox.Location = new System.Drawing.Point(135, 97);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(406, 20);
            this.passwordTextBox.TabIndex = 3;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::AwsAdfsCredentialGenerator.Properties.Settings.Default, "Username", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.usernameTextBox.Enabled = false;
            this.usernameTextBox.Location = new System.Drawing.Point(135, 73);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(406, 20);
            this.usernameTextBox.TabIndex = 2;
            this.usernameTextBox.Text = global::AwsAdfsCredentialGenerator.Properties.Settings.Default.Username;
            // 
            // useCurrentUserCheckBox
            // 
            this.useCurrentUserCheckBox.AutoSize = true;
            this.useCurrentUserCheckBox.Checked = global::AwsAdfsCredentialGenerator.Properties.Settings.Default.UseCurrentUser;
            this.useCurrentUserCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useCurrentUserCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::AwsAdfsCredentialGenerator.Properties.Settings.Default, "UseCurrentUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.useCurrentUserCheckBox.Location = new System.Drawing.Point(136, 51);
            this.useCurrentUserCheckBox.Name = "useCurrentUserCheckBox";
            this.useCurrentUserCheckBox.Size = new System.Drawing.Size(104, 17);
            this.useCurrentUserCheckBox.TabIndex = 12;
            this.useCurrentUserCheckBox.Text = "Use current user";
            this.useCurrentUserCheckBox.UseVisualStyleBackColor = true;
            this.useCurrentUserCheckBox.CheckedChanged += new System.EventHandler(this.useCurrentUser_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.countdownLabel);
            this.panel1.Controls.Add(this.errorPanel);
            this.panel1.Controls.Add(this.refreshCredentialsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 310);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 37);
            this.panel1.TabIndex = 1;
            // 
            // countdownLabel
            // 
            this.countdownLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.countdownLabel.AutoSize = true;
            this.countdownLabel.Location = new System.Drawing.Point(365, 11);
            this.countdownLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countdownLabel.Name = "countdownLabel";
            this.countdownLabel.Size = new System.Drawing.Size(34, 13);
            this.countdownLabel.TabIndex = 3;
            this.countdownLabel.Text = "00:00";
            // 
            // errorPanel
            // 
            this.errorPanel.Controls.Add(this.label2);
            this.errorPanel.Controls.Add(this.pictureBox1);
            this.errorPanel.Location = new System.Drawing.Point(2, 4);
            this.errorPanel.Margin = new System.Windows.Forms.Padding(2);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(179, 29);
            this.errorPanel.TabIndex = 2;
            this.errorPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Refresh failed. Check log.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // refreshCredentialsButton
            // 
            this.refreshCredentialsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshCredentialsButton.Location = new System.Drawing.Point(399, 4);
            this.refreshCredentialsButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshCredentialsButton.Name = "refreshCredentialsButton";
            this.refreshCredentialsButton.Size = new System.Drawing.Size(138, 29);
            this.refreshCredentialsButton.TabIndex = 0;
            this.refreshCredentialsButton.Text = "Refresh Credentials Now";
            this.refreshCredentialsButton.UseVisualStyleBackColor = true;
            this.refreshCredentialsButton.Click += new System.EventHandler(this.refreshCredentialsButton_Click);
            // 
            // logTab
            // 
            this.logTab.Controls.Add(this.logTextBox);
            this.logTab.Location = new System.Drawing.Point(4, 22);
            this.logTab.Margin = new System.Windows.Forms.Padding(2);
            this.logTab.Name = "logTab";
            this.logTab.Padding = new System.Windows.Forms.Padding(2);
            this.logTab.Size = new System.Drawing.Size(543, 349);
            this.logTab.TabIndex = 1;
            this.logTab.Text = "Log";
            this.logTab.UseVisualStyleBackColor = true;
            // 
            // logTextBox
            // 
            this.logTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTextBox.Location = new System.Drawing.Point(2, 2);
            this.logTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logTextBox.Size = new System.Drawing.Size(539, 345);
            this.logTextBox.TabIndex = 14;
            this.logTextBox.UseSystemPasswordChar = true;
            // 
            // aboutTab
            // 
            this.aboutTab.Controls.Add(this.projectLinkLabel);
            this.aboutTab.Controls.Add(this.aboutLabel);
            this.aboutTab.Location = new System.Drawing.Point(4, 22);
            this.aboutTab.Margin = new System.Windows.Forms.Padding(2);
            this.aboutTab.Name = "aboutTab";
            this.aboutTab.Size = new System.Drawing.Size(543, 349);
            this.aboutTab.TabIndex = 2;
            this.aboutTab.Text = "About";
            this.aboutTab.UseVisualStyleBackColor = true;
            // 
            // projectLinkLabel
            // 
            this.projectLinkLabel.AutoSize = true;
            this.projectLinkLabel.Location = new System.Drawing.Point(2, 55);
            this.projectLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.projectLinkLabel.Name = "projectLinkLabel";
            this.projectLinkLabel.Size = new System.Drawing.Size(128, 13);
            this.projectLinkLabel.TabIndex = 2;
            this.projectLinkLabel.TabStop = true;
            this.projectLinkLabel.Text = "Visit the project on Github";
            // 
            // aboutLabel
            // 
            this.aboutLabel.Location = new System.Drawing.Point(2, 0);
            this.aboutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(369, 55);
            this.aboutLabel.TabIndex = 1;
            this.aboutLabel.Text = resources.GetString("aboutLabel.Text");
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "AWS ADFS Credential Generator is running in background and will automatically upd" +
    "ate the credential file.";
            this.notifyIcon.BalloonTipTitle = "AWS ADFS Credential Generator";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "AWS ADFS Credential Generator";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(551, 375);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(439, 280);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "AWS ADFS Credential Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.errorPanel.ResumeLayout(false);
            this.errorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.logTab.ResumeLayout(false);
            this.logTab.PerformLayout();
            this.aboutTab.ResumeLayout(false);
            this.aboutTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage logTab;
        private System.Windows.Forms.TabPage aboutTab;
        private System.Windows.Forms.LinkLabel projectLinkLabel;
        private System.Windows.Forms.Label aboutLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label adfsUrlLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox loginToRPTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adfsUrlTextBox;
        private System.Windows.Forms.Label samlProviderNameLabel;
        private System.Windows.Forms.TextBox samlProviderNameTextBox;
        private System.Windows.Forms.Label credentialFilePathLabel;
        private System.Windows.Forms.TextBox credentialFilePathTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelProfiles;
        private System.Windows.Forms.TextBox profilesTextBox;
        private System.Windows.Forms.Button refreshCredentialsButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label countdownLabel;
        private System.Windows.Forms.CheckBox useCurrentUserCheckBox;
    }
}

