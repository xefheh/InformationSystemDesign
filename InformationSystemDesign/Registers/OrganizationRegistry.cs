using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Cards;

namespace InformationSystemDesign.Registers
{
    internal class OrganizationRegistry : IRegistry<OrganizationCard>
    {
        private readonly IList<OrganizationCard> _organizationCards;
        public OrganizationRegistry() => _organizationCards = new List<OrganizationCard>();

        public void AddCard(OrganizationCard card) => _organizationCards.Add(card);

        public void RemoveCard(OrganizationCard card) => _organizationCards.Remove(card);

        // TODO: realize UpdateCard method;
        public void UpdateCard(OrganizationCard card, params object[] inputData) =>
            throw new NotImplementedException();

        public OrganizationCard GetCard(int cardId) => _organizationCards.First(card =>
            card.INN == cardId);
    }
}
