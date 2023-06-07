using System.Collections;
using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Enumerators;
using InformationSystemDesign.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Registers
{
    internal class AnimalRegistry : IRegistry<AnimalCard>
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

        public BindingList<AnimalCard> GetCards(params Predicate<AnimalCard>[] filters)
        {
            return filters.Length == 0 ? _storage.GetAnimalCards() :
                new BindingList<AnimalCard>(_storage.GetAnimalCards().Where(animalCard => 
                    filters.All(filter => filter(animalCard))).ToList());
        }

        public void UpdateStorage() => _storage.SaveUpdates();

        public void UpdateCardValues(AnimalCard card, params object[] inputData)
        {
            card.Address = (string)inputData[0];
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
            new ((string)inputData[0], (AnimalType)inputData[1],
                (Sex)inputData[2], (DateTime)inputData[3], (int)inputData[4], (string)inputData[5],
                (byte[])inputData[6], (string)inputData[7], (string)inputData[8]);

        public IEnumerable<InspectionCard> GetInspectionCardsByAnimalId(int animalId) =>
            _storage.GetInspectionCardById(animalId);
    }
}