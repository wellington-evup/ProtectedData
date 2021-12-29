using ProtectedData.Core.Enums;
using System;

namespace ProtectedData.Core
{
    public class Email : SingleBase<string>, ISensitiveData
    {
        public static ESensitiveDataType SensitiveDataType { get; } = ESensitiveDataType.Contact;

        public Email()
        {
        }

        public Email(string value) : base(value)
        {
        }
    }
}
