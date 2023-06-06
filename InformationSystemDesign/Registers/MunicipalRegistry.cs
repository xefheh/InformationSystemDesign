using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Cards;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace InformationSystemDesign.Registers
{
    internal class MunicipalRegistry : IRegistry<MunicipalCard>

    {
        private readonly Storage _storage;
        public MunicipalRegistry(Storage storage) =>
            _storage = storage;

        public void AddCard(MunicipalCard card) => _storage.AddMunicipalCard(card);

        public void RemoveCard(MunicipalCard card) => _storage.RemoveMunicipalCard(card);

        // TODO: realize UpdateCard method;
        public void UpdateCard(MunicipalCard card, params object[] inputData) =>
            throw new NotImplementedException();

        public MunicipalCard GetCard(int cardId) => _storage.GetMunicipalCard(cardId);
        public BindingList<MunicipalCard> GetCards() => new(_storage.GetMunicipalCards());
    }
}
