using ProtectedData.Core.Enums;
using System;

namespace ProtectedData.Core
{
    public class CNPJ : SingleBase<string>, ISensitiveData
    {
        public static ESensitiveDataType SensitiveDataType { get; } = ESensitiveDataType.Identification;

        public CNPJ()
        {
        }

        public CNPJ(string value) : base(value)
        {
        }
    }
}
