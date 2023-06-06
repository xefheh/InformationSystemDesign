using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Registers
{
    internal class AnimalRegistry : IRegistry<AnimalCard>
    {
        private readonly Storage _storage;

        public AnimalRegistry(Storage storage) => _storage = storage;

        public void AddCard(AnimalCard card) => _storage.AddAnimalCard(card);

        public void RemoveCard(AnimalCard card) => _storage.RemoveAnimalCard(card);

        // TODO: realize UpdateCard method;
        public void UpdateCard(AnimalCard card, params object[] inputData) =>
            throw new NotImplementedException();

        public AnimalCard GetCard(int cardId) => _storage.GetAnimalCard(cardId);

        public BindingList<AnimalCard> GetCards() => new (_storage.GetAnimalCards());
    }
}
