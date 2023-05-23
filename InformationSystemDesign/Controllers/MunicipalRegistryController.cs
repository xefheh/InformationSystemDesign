using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Registers;

namespace InformationSystemDesign.Controllers
{
    internal class MunicipalRegistryController : IController<MunicipalCard>
    {
        private readonly IRegistry<MunicipalCard> _municipalRegistry;

        public MunicipalRegistryController() =>
            _municipalRegistry = new MunicipalRegistry();

        public void AddCard(params object[] inputData) =>
            _municipalRegistry.AddCard(CreateCard(inputData));

        public MunicipalCard GetCard(int cardId) =>
            _municipalRegistry.GetCard(cardId);

        public void RemoveCard(MunicipalCard card) =>
            _municipalRegistry.RemoveCard(card);

        public void UpdateCard(MunicipalCard card, params object[] inputData) =>
            _municipalRegistry.UpdateCard(card, inputData);

        // TODO: realize GetCards method;
        public IEnumerable<MunicipalCard> GetCards(params object[] inputData) =>
            throw new NotImplementedException();

        // TODO: realize CreateCard method;
        private static MunicipalCard CreateCard(params object[] inputData)
            => throw new NotImplementedException();
    }
}
