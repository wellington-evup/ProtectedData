using ProtectedData.Core.Enums;
using System;

namespace ProtectedData.Core
{
    public class CPF : SingleBase<string>, ISensitiveData
    {
        public static ESensitiveDataType SensitiveDataType { get; } = ESensitiveDataType.Identification;

        public CPF()
        {
        }

        public CPF(string value) : base(value)
        {
        }
    }
}
