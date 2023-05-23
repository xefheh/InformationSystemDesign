using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Registers
{
    internal class AnimalRegistry : IRegistry<AnimalCard>
    {
        private readonly IList<AnimalCard> _animalCards;
        
        public AnimalRegistry() => _animalCards = new List<AnimalCard>();

        public void AddCard(AnimalCard card) => _animalCards.Add(card);

        public void RemoveCard(AnimalCard card) => _animalCards.Remove(card);

        // TODO: realize UpdateCard method;
        public void UpdateCard(AnimalCard card, params object[] inputData) =>
            throw new NotImplementedException();

        public AnimalCard GetCard(int cardId) => _animalCards.First(card =>
            card.RegNumber == cardId);
    }
}
