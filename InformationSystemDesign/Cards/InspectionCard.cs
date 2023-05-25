using System.ComponentModel;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Cards
{
    internal class InspectionCard
    {
        public InspectionCard(AnimalCard inspectedAnimal, string behaviourFeatures, string animalCondition, float bodyTemperature, string skinCover, string woolCondition, string injures, bool isNeedHelp, string diagnosis, string manipulations, bool isAssignedHelp, DateTime inspectionDate, string doctorFIO, string doctorPosition, string vetClinic, string municipalContract)
        {
            InspectedAnimal = inspectedAnimal;
            BehaviourFeatures = behaviourFeatures;
            AnimalCondition = animalCondition;
            BodyTemperature = bodyTemperature;
            SkinCover = skinCover;
            WoolCondition = woolCondition;
            Injures = injures;
            IsNeedHelp = isNeedHelp;
            Diagnosis = diagnosis;
            Manipulations = manipulations;
            IsAssignedHelp = isAssignedHelp;
            InspectionDate = inspectionDate;
            DoctorFIO = doctorFIO;
            DoctorPosition = doctorPosition;
            VetClinic = vetClinic;
            MunicipalContract = municipalContract;
        }

        [DisplayName("Осмотренное животное")]
        public AnimalCard InspectedAnimal { get; private set; }
        [DisplayName("Особенности поведения")]
        public string BehaviourFeatures { get; private set; }
        [DisplayName("Состояние животного")]
        public string AnimalCondition { get; private set; }
        [DisplayName("Температура тела")]
        public float BodyTemperature { get; private set; }
        [DisplayName("Кожные покровы")]
        public string SkinCover { get; private set; }
        [DisplayName("Состояние шерсти")]
        public string WoolCondition { get; private set; }
        [DisplayName("Ранения, травмы и другие повреждения")]
        public string Injures { get; private set; }
        [DisplayName("Требуется экстренная помощь")]
        public bool IsNeedHelp { get; private set; }
        [DisplayName("Диагноз")]
        public string Diagnosis { get; private set; }
        [DisplayName("Проведённые манипуляции")]
        public string Manipulations { get; private set; }
        [DisplayName("Назначено лечения")]
        public bool IsAssignedHelp { get; private set; }
        [DisplayName("Дата осмотра")]
        public DateTime InspectionDate { get; private set; }
        // TODO: change on concrete type
        [DisplayName("ФИО ветеринарного специалиста")]
        public string DoctorFIO { get; private set; }
        // TODO: change on concrete type
        [DisplayName("Должность ветеринарного специалиста")]
        public string DoctorPosition { get; private set; }
        // TODO: change on concrete type
        [DisplayName("Ветклиника, в которой проведён осмотр")]
        public string VetClinic { get; private set; }
        // TODO: change on concrete type
        [DisplayName("Муниципальный контракт")]
        public string MunicipalContract { get; private set; }
    }
}
