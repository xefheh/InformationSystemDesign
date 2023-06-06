using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using InformationSystemDesign.Enumerators;
using InformationSystemDesign.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Cards
{
    [PrimaryKey(nameof(RegNumber))]
    public class AnimalCard
    {
        public AnimalCard(string address, AnimalType animalType,
            Sex sex, DateTime birthDate, int chipNumber,
            string name, byte[] photo, string specialSigns,
            string ownerFeatures)
        {
            Address = address;
            AnimalType = animalType;
            Sex = sex;
            BirthDate = birthDate;
            ChipNumber = chipNumber;
            Name = name;
            Photo = photo;
            SpecialSigns = specialSigns;
            OwnerFeatures = ownerFeatures;
        }

        [DisplayName("Регистрационный номер")] public int RegNumber { get; set; }
        [DisplayName("Населённый пункт")] public string Address { get; set; }
        [DisplayName("Категория животного")] public AnimalType AnimalType { get; set; }
        [DisplayName("Пол животного")] public Sex Sex { get; set; }

        [DisplayName("Год рождения"), DataType(DataType.Date), DisplayFormat(DataFormatString = "{0: dd/MM/YYYY}")] 
        public DateTime BirthDate { get; set; }

        [DisplayName("Номер электронного чипа")] public int ChipNumber { get; set; }

        [DisplayName("Кличка животного")] public string Name { get; set; }
        [DisplayName("Фотография животного"), Browsable(false)] public byte[] Photo { get; set; }
        [DisplayName("Особые приметы")] public string SpecialSigns { get; set; } 
        [NotMapped] public OwnerFeatures[] InternOwnerFeatures { get; private set; }

        [DisplayName("Наличие признаков владельца")]
        public string OwnerFeatures
        {
            get => string.Join(",", InternOwnerFeatures);
            set
            {
                var _ownerFeatures = value;
                InternOwnerFeatures = _ownerFeatures.Split(',', StringSplitOptions.RemoveEmptyEntries)
                    .Select(Enum.Parse<OwnerFeatures>).ToArray();
            }
        }
    }
}
