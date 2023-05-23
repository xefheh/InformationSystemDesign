using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Cards;

namespace InformationSystemDesign.Registers
{
    internal class MunicipalRegistry : IRegistry<MunicipalCard>
    {
        private readonly IList<MunicipalCard> _municipalCards;
        public MunicipalRegistry() => _municipalCards = new List<MunicipalCard>();

        public void AddCard(MunicipalCard card) => _municipalCards.Add(card);

        public void RemoveCard(MunicipalCard card) => _municipalCards.Remove(card);

        // TODO: realize UpdateCard method;
        public void UpdateCard(MunicipalCard card, params object[] inputData) =>
            throw new NotImplementedException();

        public MunicipalCard GetCard(int cardId) => _municipalCards.First(card =>
            card.Number == cardId);
    }
}
