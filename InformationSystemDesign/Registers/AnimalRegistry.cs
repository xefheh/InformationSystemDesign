using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Enumerators;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.StorageParts;

namespace InformationSystemDesign.Registers
{
    internal class AnimalRegistry : IRegistry<AnimalCard>, ILocalityRegistry
    {
        private readonly Storage _storage;

        public AnimalRegistry(Storage storage) => _storage = storage;

        public void AddCard(params object[] inputData) => 
            _storage.AddAnimalCard(CreateCard(inputData));

        public void RemoveCard(AnimalCard card) => _storage.RemoveAnimalCard(card);

        public void UpdateCard(AnimalCard card, params object[] inputData)
        {
            UpdateCardValues(card, inputData);
            _storage.SaveUpdates();
        }

        public AnimalCard GetCard(object cardId) => _storage.GetAnimalCard(cardId);

        public void UpdateCardValues(AnimalCard card, params object[] inputData)
        {
            card.Locality = (LocalityCard)inputData[0];
            card.AnimalType = (AnimalType)inputData[1];
            card.Sex = (Sex)inputData[2];
            card.BirthDate = (DateTime)inputData[3];
            card.ChipNumber = (int)inputData[4];
            card.Name = (string)inputData[5];
            card.Photo = (byte[])inputData[6];
            card.SpecialSigns = (string)inputData[7];
            card.OwnerFeatures = (string)inputData[8];
        }

        public AnimalCard CreateCard(params object[] inputData) =>
            new ((AnimalType)inputData[1],
                (Sex)inputData[2], (DateTime)inputData[3], (int)inputData[4], (string)inputData[5],
                (byte[])inputData[6], (string)inputData[7], (string)inputData[8])
            {
                Locality = (LocalityCard)inputData[0]
            };

        public BindingList<AnimalCard> GetCards() => _storage.GetAnimalCards();

        public BindingList<LocalityCard> GetLocalities() => _storage.GetLocalitiesCards();
    }
}