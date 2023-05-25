using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Registers
{
    internal class AnimalRegistry : IRegistry<AnimalCard>
    {
        private readonly DbSet<AnimalCard> _animalCards;

        public AnimalRegistry(DbSet<AnimalCard> animalCards) => _animalCards = animalCards;

        public void AddCard(AnimalCard card) => _animalCards.Add(card);

        public void RemoveCard(AnimalCard card) => _animalCards.Remove(card);

        // TODO: realize UpdateCard method;
        public void UpdateCard(AnimalCard card, params object[] inputData) =>
            throw new NotImplementedException();

        public AnimalCard GetCard(int cardId) => _animalCards.First(card =>
            card.RegNumber == cardId);

        public BindingList<AnimalCard> GetCards() => new (_animalCards.ToList());
    }
}
