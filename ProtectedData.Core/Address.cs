using ProtectedData.Core.Enums;

namespace ProtectedData.Core
{
    public class Address : ISensitiveData
    {
        public static ESensitiveDataType SensitiveDataType { get; } = ESensitiveDataType.Contact;

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public CEP CEP { get; set; }
    }
}
