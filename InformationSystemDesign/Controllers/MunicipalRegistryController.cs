using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Exceptions;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Registers;

namespace InformationSystemDesign.Controllers
{
    public class MunicipalRegistryController : IController<MunicipalCard>, ILocalityController, IValidation
    {
        private readonly IRegistry<MunicipalCard> _municipalRegistry;
        private readonly IPermissionAction _permissionAction;

        public MunicipalRegistryController(IRegistry<MunicipalCard> municipalRegistry,
            IPermissionAction permissionAction)
        {
            _municipalRegistry = municipalRegistry;
            _permissionAction = permissionAction;
        }

        public void AddCard(params object[] inputData)
        {
            if (!_permissionAction.CanAddCard()) throw new PermissionException("Can`t add card!");
            if (!IsValid(inputData)) throw new ValidationException("No valid card!");
            _municipalRegistry.AddCard(inputData);
        }

        public MunicipalCard GetCard(object cardId) =>
            _municipalRegistry.GetCard(cardId);

        public void RemoveCard(MunicipalCard card)
        {
            if (!_permissionAction.CanRemoveCard()) throw new PermissionException("Can`t remove card!");
            _municipalRegistry.RemoveCard(card);
        }

        public void UpdateCard(MunicipalCard card, params object[] inputData)
        {
            if (!_permissionAction.CanUpdateCard()) throw new PermissionException("Can`t update card!");
            if (!IsValid(inputData)) throw new ValidationException("No valid card!");
            _municipalRegistry.UpdateCard(card, inputData);
        }

        public BindingList<LocalityCard> GetLocalities() => ((ILocalityRegistry)_municipalRegistry).GetLocalities();

        public bool IsValid(params object[] inputData)
        {
            foreach (var property in inputData)
            {
                switch (property)
                {
                    case string and "":
                    case null:
                        return false;
                }
            }
            return true;
        }

        public BindingList<MunicipalCard> GetCards() => _municipalRegistry.GetCards();
    }
}
