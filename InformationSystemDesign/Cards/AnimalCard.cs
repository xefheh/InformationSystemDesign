using System.ComponentModel;
using InformationSystemDesign.Enumerators;

namespace InformationSystemDesign.Cards
{
    internal class AnimalCard
    {
        public AnimalCard(int regNumber, string address, AnimalType animalType,
            Sex sex, DateTime birthDate, int chipNumber,
            string name, Bitmap photo, string specialSigns, 
            IEnumerable<OwnerFeatures> ownerFeatures)
        {
            RegNumber = regNumber;
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

        [DisplayName("Регистрационный номер")]
        public int RegNumber { get; private set; }
        [DisplayName("Населённый пункт")]
        public string Address { get; private set; }
        [DisplayName("Категория животного")]
        public AnimalType AnimalType { get; private set; }
        [DisplayName("Пол животного")]
        public Sex Sex { get; private set; }
        [DisplayName("Год рождения")]
        public DateTime BirthDate { get; private set; }
        [DisplayName("Номер электронного чипа")]
        public int ChipNumber { get; private set; }
        [DisplayName("Кличка животного")]
        public string Name { get; private set; }
        [DisplayName("Фотография животного")]
        public Bitmap Photo { get; private set; }
        [DisplayName("Особые приметы")]
        public string SpecialSigns { get; private set; }
        [DisplayName("Наличие признаков владельца")]
        public IEnumerable<OwnerFeatures> OwnerFeatures { get; private set; }

    }
}
