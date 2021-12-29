using ProtectedData.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProtectedData.Core
{
    public class SensitiveDataManager
    {
        private readonly IEnumerable<BlockedEmail> _blockedEmails;
        private readonly IEnumerable<BlockedPhone> _blockedPhones;
        
        readonly Func<UserProfile, ESensitiveDataType, bool> f1 = new Func<UserProfile, ESensitiveDataType, bool>((x, y) => { return x.SensitiveDataTypes.Contains(y); });
        readonly Func<ContactPermission, bool> f2 = new Func<ContactPermission, bool>((x) => { return x.ByEmail; });
        readonly Func<ContactPermission, bool> f3 = new Func<ContactPermission, bool>((x) => { return x.ByPhone; });
        readonly Func<Email, IEnumerable<BlockedEmail>, bool> f4 = new Func<Email, IEnumerable<BlockedEmail>, bool>((x, y) => { return !y.Select(s => s.Email).Contains(x); });
        readonly Func<Phone, IEnumerable<BlockedPhone>, bool> f5 = new Func<Phone, IEnumerable<BlockedPhone>, bool>((x, y) => { return !y.Select(s => s.Phone).Contains(x); });

        public SensitiveDataManager(IEnumerable<BlockedEmail> blockedEmails, IEnumerable<BlockedPhone> blockedPhones)
        {
            _blockedEmails = blockedEmails;
            _blockedPhones = blockedPhones;
        }

        public bool IsAbleToAccessAddress(UserProfile userProfile)
        {
            return f1(userProfile, Address.SensitiveDataType);
        }

        public bool IsAbleToAccessBirthDate(UserProfile userProfile)
        {
            return f1(userProfile, BirthDate.SensitiveDataType);
        }

        public bool IsAbleToAccessCPF(UserProfile userProfile)
        {
            return f1(userProfile, CPF.SensitiveDataType);
        }

        public bool IsAbleToAccessCNPJ(UserProfile userProfile)
        {
            return f1(userProfile, CNPJ.SensitiveDataType);
        }

        public bool IsAbleToAccessPersonName(UserProfile userProfile)
        {
            return f1(userProfile, PersonName.SensitiveDataType);
        }

        public bool IsAbleToAccessEmail(UserProfile userProfile, ContactPermission contactPermission, Email email)
        {
            return f1(userProfile, Email.SensitiveDataType) && f2(contactPermission) && f4(email, _blockedEmails);
        }

        public bool IsAbleToAccessPhone(UserProfile userProfile, ContactPermission contactPermission, Phone phone)
        {
            return f1(userProfile, Email.SensitiveDataType) && f3(contactPermission) && f5(phone, _blockedPhones);
        }

        public bool IsAbleToAccessRG(UserProfile userProfile)
        {
            return f1(userProfile, RG.SensitiveDataType);
        }
    }
}
