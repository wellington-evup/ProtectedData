using ProtectedData.Core.Enums;

namespace ProtectedData.Core
{
    public class Phone : ISensitiveData
    {
        public static ESensitiveDataType SensitiveDataType { get; } = ESensitiveDataType.Contact;

        public int? DDI { get; set; } = 55;
        public int DDD { get; set; }
        public int Number { get; set; }

        public Phone()
        {
        }

        public Phone(int ddd, int number)
        {
            DDD = ddd;
            Number = number;
        }

        public Phone(int ddi, int ddd, int number) : this(ddd, number)
        {
            DDI = ddi;
        }
    }
}
