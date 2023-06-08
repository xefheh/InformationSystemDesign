using InformationSystemDesign.Exceptions;
using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Controllers
{
    internal class OrganizationRegistryController : IController<OrganizationCard>, ILocalityController, IValidation
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
            if (!IsValid(inputData)) throw new ValidationException("No valid card!");
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
            if (!IsValid(inputData)) throw new ValidationException("No valid card!");
            _organizationRegistry.UpdateCard(card, inputData);
        }

        public bool IsValid(params object[] inputData)
        {
            return inputData.All(property => property is not (string and ""));
        }

        public BindingList<OrganizationCard> GetCards() => _organizationRegistry.GetCards();

        public BindingList<LocalityCard> GetLocalities() => ((ILocalityRegistry)_organizationRegistry).GetLocalities();
    }
}
