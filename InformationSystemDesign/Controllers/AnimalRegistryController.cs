using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Registers;

namespace InformationSystemDesign.Controllers
{
    internal class AnimalRegistryController : IController<AnimalCard>   
    {
        private readonly IRegistry<AnimalCard> _animalRegistry;

        public AnimalRegistryController(IRegistry<AnimalCard> animalRegistry) => 
            _animalRegistry = animalRegistry;

        public void AddCard(params object[] inputData) =>
            _animalRegistry.AddCard(CreateCard(inputData));

        public AnimalCard GetCard(int cardId) =>
            _animalRegistry.GetCard(cardId);

        public void RemoveCard(AnimalCard card) =>
            _animalRegistry.RemoveCard(card);

        public void UpdateCard(AnimalCard card, params object[] inputData) =>
            _animalRegistry.UpdateCard(card, inputData);

        // TODO: realize GetCards method;
        public IEnumerable<AnimalCard> GetCards(params object[] inputData) =>
            throw new NotImplementedException();

        // TODO: realize CreateCard method;
        private static AnimalCard CreateCard(params object[] inputData)
            => throw new NotImplementedException();
    }
}