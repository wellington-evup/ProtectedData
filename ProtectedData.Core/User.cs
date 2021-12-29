namespace ProtectedData.Core
{
    public class User
    {
        public LoginId LoginId { get; set; }
        public Password Password { get; set; }
        public UserProfile Profile { get; set; }
    }
}
