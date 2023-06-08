using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InformationSystemDesign.Cards
{
    public class InspectionCard
    {
        [Browsable(false), Key]
        public int InspectionNumber { get; set; }

        [Browsable(false)]
        public AnimalCard InspectedAnimal { get; set; }
        [DisplayName("Особенности поведения")]
        public string BehaviourFeatures { get; set; }
        [DisplayName("Состояние животного")]
        public string AnimalCondition { get; set; }
        [DisplayName("Температура тела")]
        public float BodyTemperature { get; set; }
        [DisplayName("Кожные покровы")]
        public string SkinCover { get; set; }
        [DisplayName("Состояние шерсти")]
        public string WoolCondition { get; set; }
        [DisplayName("Ранения, травмы и другие повреждения")]
        public string Injures { get; set; }
        [DisplayName("Требуется экстренная помощь")]
        public bool IsNeedHelp { get; set; }
        [DisplayName("Диагноз")]
        public string Diagnosis { get; set; }
        [DisplayName("Проведённые манипуляции")]
        public string Manipulations { get; set; }
        [DisplayName("Назначено лечения")]
        public bool IsAssignedHelp { get; set; }
        [DisplayName("Дата осмотра")]
        public DateTime InspectionDate { get; set; }

        [DisplayName("ФИО ветеринарного специалиста")]
        public string DoctorFIO { get; set; }

        [DisplayName("Должность ветеринарного специалиста")]
        public string DoctorPosition { get; set; }
        [DisplayName("Ветклиника, в которой проведён осмотр")]
        public string VetClinic { get; set; }
        [DisplayName("Номер муниципального контракта")]
        public MunicipalCard MunicipalContract { get; set; }

        public string GetAnimalLocale() => InspectedAnimal.GetLocale();

        public List<LocalityCard> GetMunicipalLocalities() => MunicipalContract.GetLocalities();
    }
}
