using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Cards;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace InformationSystemDesign.Registers
{
    internal class OrganizationRegistry : IRegistry<OrganizationCard>
    {
        private readonly Storage _storage;

        public OrganizationRegistry(Storage storage) =>
            _storage = storage;
        public void AddCard(OrganizationCard card) => _storage.AddOrganizationCard(card);

        public void RemoveCard(OrganizationCard card) => _storage.RemoveOrganizationCard(card);

        // TODO: realize UpdateCard method;
        public void UpdateCard(OrganizationCard card, params object[] inputData) =>
            throw new NotImplementedException();

        public OrganizationCard GetCard(int cardId) => _storage.GetOrganizationCard(cardId);

        public BindingList<OrganizationCard> GetCards() => new(_storage.GetOrganizationCards());
    }
}
