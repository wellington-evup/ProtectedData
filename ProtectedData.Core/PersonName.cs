using ProtectedData.Core.Enums;
using System;

namespace ProtectedData.Core
{
    public class PersonName : SingleBase<string>, ISensitiveData
    {
        public static ESensitiveDataType SensitiveDataType { get; } = ESensitiveDataType.Personal;

        public PersonName()
        {
        }

        public PersonName(string value) : base(value)
        {
        }
    }
}
