using ProtectedData.Core.Enums;
using System;

namespace ProtectedData.Core
{
    public class BirthDate : SingleBase<DateTime?>, ISensitiveData
    {
        public static ESensitiveDataType SensitiveDataType { get; } = ESensitiveDataType.Identification;

        public BirthDate()
        {
        }

        public BirthDate(DateTime? value) : base(value)
        {
        }
    }
}
