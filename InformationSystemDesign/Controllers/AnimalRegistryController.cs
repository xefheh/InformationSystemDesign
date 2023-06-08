using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Registers;

namespace InformationSystemDesign.Controllers
{
    public class AnimalRegistryController : IController<AnimalCard>   
    {
        private readonly IRegistry<AnimalCard> _animalRegistry;
        private readonly IPermissionAction _permissionAction;

        public AnimalRegistryController(IRegistry<AnimalCard> animalRegistry, IPermissionAction permissionAction)
        {
            _animalRegistry = animalRegistry;
            _permissionAction = permissionAction;
        }

        public void AddCard(params object[] inputData)
        {
            if (!_permissionAction.CanAddCard()) throw new PermissionException("Can`t add new card!");
            if (!IsValidCard(inputData)) throw new ValidException("No valid card!");
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
            if (!IsValidCard(inputData)) throw new ValidException("No valid card!");
            _animalRegistry.UpdateCard(card, inputData);
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

        public BindingList<AnimalCard> GetCards(params Predicate<AnimalCard>[] inputData) => _animalRegistry.GetCards(inputData);

        public void InvokeStorageUpdating() => ((AnimalRegistry)_animalRegistry).UpdateStorage();

        public IEnumerable<InspectionCard> GetInspectionCardByAnimalId(int id) =>
            (((AnimalRegistry)_animalRegistry).GetInspectionCardsByAnimalId(id));

    }   
}