namespace ProtectedData.Core
{
    public class ContactPermission
    {
        public bool ByApp { get; set; } = true;
        public bool ByEmail { get; set; } = true;
        public bool ByPhone { get; set; } = true;
    }
}
