using System.ComponentModel;

namespace InformationSystemDesign.Cards
{
    internal class OrganizationCard
    {
        public OrganizationCard(string fullName, int inn, int kpp, string regAddress,
            string organizationType, string ownerType, string city)
        {
            FullName = fullName;
            INN = inn;
            KPP = kpp;
            RegAddress = regAddress;
            OrganizationType = organizationType;
            OwnerType = ownerType;
            City = city;
        }

        [DisplayName("Полное наименование организации")]
        public string FullName { get; private set; }
        [DisplayName("ИНН")]
        public int INN { get; private set; }
        [DisplayName("КПП")]
        public int KPP { get; private set; }
        [DisplayName("Адрес регистрации")]
        public string RegAddress { get; private set; }
        // TODO: change to concrete enumeration
        [DisplayName("Тип организации")]
        public string OrganizationType { get; private set; }
        // TODO: change to concrete enumeration
        [DisplayName("ИП/Юр. лицо")]
        public string OwnerType { get; private set; }
        [DisplayName("Населённый пункт")]
        public string City { get; private set; }
    }
}
