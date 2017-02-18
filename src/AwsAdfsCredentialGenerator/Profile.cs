namespace AwsAdfsCredentialGenerator
{
    using System;

    public sealed class Profile : IComparable<Profile>, IComparable
    {
        public int CompareTo(Profile other)
        {
            if(ReferenceEquals(this, other)) return 0;
            if(ReferenceEquals(null, other)) return 1;
            return string.Compare(Name, other.Name, StringComparison.InvariantCultureIgnoreCase);
        }

        public int CompareTo(object obj)
        {
            if(ReferenceEquals(null, obj)) return 1;
            if(ReferenceEquals(this, obj)) return 0;
            if(!(obj is Profile)) throw new ArgumentException($"Object must be of type {nameof(Profile)}");
            return CompareTo((Profile) obj);
        }

        public Profile(string name, string awsAccessKeyId, string awsSecretAccess, string awsSessionToken)
        {
            Name = name;
            AwsAccessKeyId = awsAccessKeyId;
            AwsSecretAccess = awsSecretAccess;
            AwsSessionToken = awsSessionToken;
        }

        public string Name { get; }

        public string AwsAccessKeyId { get; }

        public string AwsSecretAccess { get; }

        public string AwsSessionToken { get; }

        public override string ToString() => Name;
    }
}