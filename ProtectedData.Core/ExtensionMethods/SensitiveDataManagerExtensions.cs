namespace ProtectedData.Core.ExtensionMethods
{
    public static class SensitiveDataManagerExtensions
    {
        public static bool IsAbleToAccessAddress(this SensitiveDataManager manager, User user)
        {
            return manager.IsAbleToAccessAddress(user.Profile);
        }

        public static bool IsAbleToAccessBirthDate(this SensitiveDataManager manager, User user)
        {
            return manager.IsAbleToAccessBirthDate(user.Profile);
        }

        public static bool IsAbleToAccessCPF(this SensitiveDataManager manager, User user)
        {
            return manager.IsAbleToAccessCPF(user.Profile);
        }

        public static bool IsAbleToAccessCNPJ(this SensitiveDataManager manager, User user)
        {
            return manager.IsAbleToAccessCNPJ(user.Profile);
        }

        public static bool IsAbleToAccessEmail(this SensitiveDataManager manager, User user, Client client)
        {
            return manager.IsAbleToAccessEmail(user.Profile, client.ContactPermission, client.Email);
        }

        public static bool IsAbleToAccessPhone(this SensitiveDataManager manager, User user, Client client)
        {
            return manager.IsAbleToAccessPhone(user.Profile, client.ContactPermission, client.Phone);
        }

        public static bool IsAbleToAccessRG(this SensitiveDataManager manager, User user)
        {
            return manager.IsAbleToAccessRG(user.Profile);
        }

        public static Address GetAddress(this SensitiveDataManager manager, User user, Client client)
        {
            return manager.IsAbleToAccessAddress(user.Profile) ? client.Address : null;
        }

        public static CPF GetCPF(this SensitiveDataManager manager, User user, Client client)
        {
            return manager.IsAbleToAccessCPF(user.Profile) ? client.CPF : null;
        }

        public static PersonName GetPersonName(this SensitiveDataManager manager, User user, Client client)
        {
            return manager.IsAbleToAccessPersonName(user.Profile) ? client.Name : null;
        }

        public static BirthDate GetBirthDate(this SensitiveDataManager manager, User user, Client client)
        {
            return manager.IsAbleToAccessBirthDate(user.Profile) ? client.BirthDate : null;
        }

        public static Email GetEmail(this SensitiveDataManager manager, User user, Client client)
        {
            return manager.IsAbleToAccessEmail(user.Profile, client.ContactPermission, client.Email) ? client.Email : null;
        }

        public static Phone GetPhone(this SensitiveDataManager manager, User user, Client client)
        {
            return manager.IsAbleToAccessPhone(user.Profile, client.ContactPermission, client.Phone) ? client.Phone : null;
        }

        public static RG GetRG(this SensitiveDataManager manager, User user, Client client)
        {
            return manager.IsAbleToAccessRG(user.Profile) ? client.RG : null;
        }
    }
}
