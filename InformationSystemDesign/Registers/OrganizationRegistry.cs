using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Cards;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace InformationSystemDesign.Registers
{
    internal class OrganizationRegistry : IRegistry<OrganizationCard>
    {
        private readonly DbSet<OrganizationCard> _organizationCards;

        public OrganizationRegistry(DbSet<OrganizationCard> organizationCards) =>
            _organizationCards = organizationCards;
        public void AddCard(OrganizationCard card) => _organizationCards.Add(card);

        public void RemoveCard(OrganizationCard card) => _organizationCards.Remove(card);

        // TODO: realize UpdateCard method;
        public void UpdateCard(OrganizationCard card, params object[] inputData) =>
            throw new NotImplementedException();

        public OrganizationCard GetCard(int cardId) => _organizationCards.First(card =>
            card.INN == cardId);

        public BindingList<OrganizationCard> GetCards() => new(_organizationCards.ToList());
    }
}
