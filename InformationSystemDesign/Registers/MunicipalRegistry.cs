﻿using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Cards;
using System.ComponentModel;

namespace InformationSystemDesign.Registers
{
    internal class MunicipalRegistry : IRegistry<MunicipalCard>

    {
        private readonly Storage _storage;
        public MunicipalRegistry(Storage storage) =>
            _storage = storage;

        public void AddCard(params object[] inputData) => _storage.AddMunicipalCard(CreateCard(inputData));

        public void RemoveCard(MunicipalCard card) => _storage.RemoveMunicipalCard(card);

        public void UpdateCard(MunicipalCard card, params object[] inputData)
        {
            UpdateCardValues(card, inputData);
            _storage.SaveUpdates();
        }

        public BindingList<LocalityCard> GetLocalitiesFromStorage() => _storage.GetLocalitiesCards();

        public MunicipalCard GetCard(object cardId) => _storage.GetMunicipalCard((int)cardId);
        public BindingList<MunicipalCard> GetCards(params Predicate<MunicipalCard>[] filters) => _storage.GetMunicipalCards();

        public void UpdateCardValues(MunicipalCard card, params object[] inputData)
        {
            card.SignDate = (DateTime)inputData[0];
            card.ValidateDate = (DateTime)inputData[1];
            card.Executor = (string)inputData[2];
            card.Customer = (string)inputData[3];
        }

        public MunicipalCard CreateCard(params object[] inputData)
        {
            var municipalCard = new MunicipalCard((DateTime)inputData[0],
                (DateTime)inputData[1],
                (string)inputData[2],
                (string)inputData[3])
            {
                LocalityCards = (List<LocalityCard>)inputData[4]
            };
            return municipalCard;
        }
    }
}
