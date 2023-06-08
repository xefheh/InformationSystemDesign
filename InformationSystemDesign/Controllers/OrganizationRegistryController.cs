using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Enumerators;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Controllers
{
    internal class OrganizationRegistryController : IController<OrganizationCard>
    {
        private readonly IRegistry<OrganizationCard> _organizationRegistry;
        private readonly IPermissionAction _permissionAction;

        public OrganizationRegistryController(IRegistry<OrganizationCard> organizationRegistry,
            IPermissionAction permissionAction)
        {
            _organizationRegistry = organizationRegistry;
            _permissionAction = permissionAction;
        }

        public void AddCard(params object[] inputData)
        {
            if (!_permissionAction.CanAddCard()) throw new PermissionException("Can`t add card!");
            if (!IsValidCard(inputData)) throw new ValidException("No valid card!");
            _organizationRegistry.AddCard(inputData);
        }

        public OrganizationCard GetCard(object cardId) =>
            _organizationRegistry.GetCard(cardId);

        public void RemoveCard(OrganizationCard card)
        {
            if (!_permissionAction.CanRemoveCard()) throw new PermissionException("Can`t remove card!");
            _organizationRegistry.RemoveCard(card);
        }

        public void UpdateCard(OrganizationCard card, params object[] inputData)
        {
            if (!_permissionAction.CanUpdateCard()) throw new PermissionException("Can`t update card!");
            if (!IsValidCard(inputData)) throw new ValidException("No valid card!");
            _organizationRegistry.UpdateCard(card, inputData);
        }

        private bool IsValidCard(params object[] inputData)
        {
            foreach (var property in inputData)
            {
                if (property.ToString() == "")
                {
                    return false;
                }
            }
            return true;
        }


        public BindingList<OrganizationCard> GetCards(params Predicate<OrganizationCard>[] inputData) => _organizationRegistry.GetCards();
    }
}
