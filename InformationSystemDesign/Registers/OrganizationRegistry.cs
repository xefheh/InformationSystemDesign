using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Cards;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using InformationSystemDesign.Enumerators;

namespace InformationSystemDesign.Registers
{
    internal class OrganizationRegistry : IRegistry<OrganizationCard>
    {
        private readonly Storage _storage;

        public OrganizationRegistry(Storage storage) =>
            _storage = storage;
        public void AddCard(params object[] inputData) => _storage.AddOrganizationCard(CreateCard(inputData));

        public void RemoveCard(OrganizationCard card) => _storage.RemoveOrganizationCard(card);

        public void UpdateCard(OrganizationCard card, params object[] inputData)
        {
            UpdateCardValues(card, inputData);
            _storage.SaveUpdates();
        }
            

        public OrganizationCard GetCard(object cardId) => _storage.GetOrganizationCard((string)cardId);

        public BindingList<OrganizationCard> GetCards() => _storage.GetOrganizationCards();

        public void UpdateCardValues(OrganizationCard card, params object[] inputData)
        {
            card.INN = (string)inputData[0];
            card.FullName = (string)inputData[1];
            card.KPP = (string)inputData[2];
            card.RegAddress = (string)inputData[3];
            card.OrganizationType = (OrganizationType)inputData[4];
            card.OwnerType = (OwnerType)inputData[5];
            card.City = (string)inputData[6];
        }

        public OrganizationCard CreateCard(params object[] inputData) =>
            new((string)inputData[0], (string)inputData[1], (string)inputData[2],
                (string)inputData[3], (OrganizationType)inputData[4],
                (OwnerType)inputData[5], (string)inputData[6]);
    }
}
