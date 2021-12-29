using System;

namespace ProtectedData.Core
{
    public class Password : SingleBase<string>
    {
        public Password()
        {
        }

        public Password(string value) : base(value)
        {
        }
    }
}
