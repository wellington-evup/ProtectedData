using ProtectedData.Core.Enums;
using System.Collections.Generic;

namespace ProtectedData.Core
{
    public class UserProfile
    {
        public string Name { get; set; }
        public List<ESensitiveDataType> SensitiveDataTypes { get; set; } = new List<ESensitiveDataType>();
    }
}
