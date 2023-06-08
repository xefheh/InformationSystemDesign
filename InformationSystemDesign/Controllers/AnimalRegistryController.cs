using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Exceptions;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Controllers
{
    public class AnimalRegistryController : IController<AnimalCard>, ILocalityController, IValidation
    {
        private readonly IRegistry<AnimalCard> _animalRegistry;
        private readonly IPermissionAction _permissionAction;

        public AnimalRegistryController(IRegistry<AnimalCard> animalRegistry, IPermissionAction permissionAction)
        {
            _animalRegistry = animalRegistry;
            _permissionAction = permissionAction;
        }

        public BindingList<AnimalCard> GetCards() => _animalRegistry.GetCards();

        public void AddCard(params object[] inputData)
        {
            if (!_permissionAction.CanAddCard()) throw new PermissionException("Can`t add new card!");
            if (!IsValid(inputData)) throw new ValidationException("No valid card!");
            _animalRegistry.AddCard(inputData);
        }

        public AnimalCard GetCard(object cardId) =>
            _animalRegistry.GetCard(cardId);

        public void RemoveCard(AnimalCard card)
        {
            if(!_permissionAction.CanRemoveCard()) throw new PermissionException("Can`t remove card!");
            _animalRegistry.RemoveCard(card);
        }

        public void UpdateCard(AnimalCard card, params object[] inputData)
        {
            if (!_permissionAction.CanUpdateCard()) throw new PermissionException("Can`t update card!");
            if (!IsValid(inputData)) throw new ValidationException("No valid card!");
            _animalRegistry.UpdateCard(card, inputData);
        }

        public bool IsValid(params object[] inputData)
        {
            foreach (var property in inputData)
            {
                switch (property)
                {
                    case string and "":
                    case byte[] photo when photo == Array.Empty<byte>():
                    case null:
                        return false;
                }
            }
            return true;
        }

        public BindingList<LocalityCard> GetLocalities() => ((ILocalityRegistry)_animalRegistry).GetLocalities();
    }   
}