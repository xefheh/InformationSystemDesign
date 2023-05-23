using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Registers;

namespace InformationSystemDesign.Controllers
{
    internal class OrganizationRegistryController : IController<OrganizationCard>
    {
        private readonly IRegistry<OrganizationCard> _organizationRegistry;

        public OrganizationRegistryController() =>
            _organizationRegistry = new OrganizationRegistry();

        public void AddCard(params object[] inputData) =>
            _organizationRegistry.AddCard(CreateCard(inputData));

        public OrganizationCard GetCard(int cardId) =>
            _organizationRegistry.GetCard(cardId);

        public void RemoveCard(OrganizationCard card) =>
            _organizationRegistry.RemoveCard(card);

        public void UpdateCard(OrganizationCard card, params object[] inputData) =>
            _organizationRegistry.UpdateCard(card, inputData);

        // TODO: realize GetCards method;
        public IEnumerable<OrganizationCard> GetCards(params object[] inputData) =>
            throw new NotImplementedException();

        // TODO: realize CreateCard method;
        private static OrganizationCard CreateCard(params object[] inputData)
            => throw new NotImplementedException();
    }
}
