using ProtectedData.Core.Enums;

namespace ProtectedData.Core
{
    public interface ISensitiveData
    {
        static ESensitiveDataType SensitiveDataType { get; }
    }
}