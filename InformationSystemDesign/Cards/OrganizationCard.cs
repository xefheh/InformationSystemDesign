using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using InformationSystemDesign.Enumerators;
using InformationSystemDesign.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Cards
{
    [PrimaryKey(nameof(INN))]
    public class OrganizationCard
    {
        public OrganizationCard(string inn,string fullName, string kpp, string regAddress,
            OrganizationType organizationType, OwnerType ownerType, string city)
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
        public string INN { get; set; }
        [DisplayName("Полное наименование организации")]
        public string FullName { get; set; }
        [DisplayName("КПП")]
        public string KPP { get; set; }
        [DisplayName("Адрес регистрации")]
        public string RegAddress { get; set; }
        [DisplayName("Тип организации")]
        public OrganizationType OrganizationType { get; set; }

        [DisplayName("ИП/Юр. лицо")]
        public OwnerType OwnerType { get; set; }
        [DisplayName("Населённый пункт")]
        public string City { get; set; }
    }
}
