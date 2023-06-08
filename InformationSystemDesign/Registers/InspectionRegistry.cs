using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Exceptions;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.StorageParts;

namespace InformationSystemDesign.Registers
{
    public class InspectionRegistry : IRegistry<InspectionCard>
    {
        private readonly Storage _storage;

        public InspectionRegistry(Storage storage) => _storage = storage;

        public BindingList<InspectionCard> GetCards() => _storage.GetInspectionCards();


        public InspectionCard CreateCard(params object[] inputData)
        {
            var inspectionCard = new InspectionCard()
            {
                InspectedAnimal = (AnimalCard)inputData[0],
                BehaviourFeatures = (string)inputData[1],
                AnimalCondition = (string)inputData[2],
                BodyTemperature = (float)inputData[3],
                SkinCover = (string)inputData[4],
                WoolCondition = (string)inputData[5],
                Injures = (string)inputData[6],
                IsNeedHelp = (bool)inputData[7],
                Diagnosis = (string)inputData[8],
                Manipulations = (string)inputData[9],
                IsAssignedHelp = (bool)inputData[10],
                InspectionDate = (DateTime)inputData[11],
                DoctorFIO = (string)inputData[12],
                DoctorPosition = (string)inputData[13],
                VetClinic = (string)inputData[14],
            };
            var municipalContract = GetMunicipalCard(inputData[15]);
            inspectionCard.MunicipalContract = municipalContract;
            return inspectionCard;
        }

        private MunicipalCard GetMunicipalCard(object id)
        {
            var municipalContract = _storage.GetMunicipalCard(id);
            if (municipalContract == null)
                throw new NullCardException("Municipal contract card not exist!");
            return municipalContract;
        }


        public void UpdateCardValues(InspectionCard card, params object[] inputData)
        {
            card.InspectedAnimal = (AnimalCard)inputData[0];
            card.BehaviourFeatures = (string)inputData[1];
            card.AnimalCondition = (string)inputData[2];
            card.BodyTemperature = (float)inputData[3];
            card.SkinCover = (string)inputData[4];
            card.WoolCondition = (string)inputData[5];
            card.Injures = (string)inputData[6];
            card.IsNeedHelp = (bool)inputData[7];
            card.Diagnosis = (string)inputData[8];
            card.Manipulations = (string)inputData[9];
            card.IsAssignedHelp = (bool)inputData[10];
            card.InspectionDate = (DateTime)inputData[11];
            card.DoctorFIO = (string)inputData[12];
            card.DoctorPosition = (string)inputData[13];
            card.VetClinic = (string)inputData[14];
            card.MunicipalContract = GetMunicipalCard(inputData[15]);
        }

        public void AddCard(params object[] inputData) => 
            _storage.AddInspectionCard(CreateCard(inputData));

        public void RemoveCard(InspectionCard card) => _storage.RemoveInspectionCard(card);

        public void UpdateCard(InspectionCard card, params object[] inputData)
        {
            UpdateCardValues(card, inputData);
            _storage.SaveUpdates();
        }

        public InspectionCard GetCard(object identity) => _storage.GetInspectionCard(identity);
    }
}
