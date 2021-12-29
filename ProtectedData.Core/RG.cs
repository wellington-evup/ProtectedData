using ProtectedData.Core.Enums;
using System;

namespace ProtectedData.Core
{
    public class RG : SingleBase<string>, ISensitiveData
    {
        public static ESensitiveDataType SensitiveDataType { get; } = ESensitiveDataType.Identification;

        public RG()
        {
        }

        public RG(string value) : base(value)
        {
        }
    }
}
