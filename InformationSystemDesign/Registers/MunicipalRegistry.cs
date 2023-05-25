using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Cards;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace InformationSystemDesign.Registers
{
    internal class MunicipalRegistry : IRegistry<MunicipalCard>

    {
        private readonly DbSet<MunicipalCard> _municipalCards;
        public MunicipalRegistry(DbSet<MunicipalCard> municipalCards) =>
            _municipalCards = municipalCards;

        public void AddCard(MunicipalCard card) => _municipalCards.Add(card);

        public void RemoveCard(MunicipalCard card) => _municipalCards.Remove(card);

        // TODO: realize UpdateCard method;
        public void UpdateCard(MunicipalCard card, params object[] inputData) =>
            throw new NotImplementedException();

        public MunicipalCard GetCard(int cardId) => _municipalCards.First(card =>
            card.Number == cardId);
        public BindingList<MunicipalCard> GetCards() => new(_municipalCards.ToList());
    }
}
