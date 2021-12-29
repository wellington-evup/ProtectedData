using System;

namespace ProtectedData.Core
{
    public class LoginId : SingleBase<string>
    {
        public LoginId()
        {
        }

        public LoginId(string value) : base(value)
        {
        }
    }
}
