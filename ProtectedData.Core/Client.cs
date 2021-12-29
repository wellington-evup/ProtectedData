namespace ProtectedData.Core
{
    public class Client
    {
        public PersonName Name { get; set; }

        public BirthDate BirthDate { get; set; }
        public CPF CPF { get; set; }
        public RG RG { get; set; }

        public Email Email { get; set; }
        public Phone Phone { get; set; }
        public Address Address { get; set; }

        public ContactPermission ContactPermission { get; set; } = new ContactPermission();
    }
}
