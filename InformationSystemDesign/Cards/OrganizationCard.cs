using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using InformationSystemDesign.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Cards
{
    [PrimaryKey(nameof(INN))]
    public class OrganizationCard
    {
        public OrganizationCard(int inn,string fullName, int kpp, string regAddress,
            string organizationType, string ownerType, string city)
        {
            INN = inn;
            FullName = fullName;
            KPP = kpp;
            RegAddress = regAddress;
            OrganizationType = organizationType;
            OwnerType = ownerType;
            City = city;
        }

        public OrganizationCard() { }

        [DisplayName("ИНН")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int INN { get; set; }
        [DisplayName("Полное наименование организации")]
        public string FullName { get; set; }
        [DisplayName("КПП")]
        public int KPP { get; set; }
        [DisplayName("Адрес регистрации")]
        public string RegAddress { get; set; }
        // TODO: change to concrete enumeration
        [DisplayName("Тип организации")]
        public string OrganizationType { get; set; }
        // TODO: change to concrete enumeration
        [DisplayName("ИП/Юр. лицо")]
        public string OwnerType { get; set; }
        [DisplayName("Населённый пункт")]
        public string City { get; set; }
    }
}
