﻿using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Registers;

namespace InformationSystemDesign.Controllers
{
    internal class MunicipalRegistryController : IController<MunicipalCard>
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
            if (!IsValidCard(inputData)) throw new ValidException("No valid card!");
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
            if (!IsValidCard(inputData)) throw new ValidException("No valid card!");
            _municipalRegistry.UpdateCard(card, inputData);
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


        public BindingList<MunicipalCard> GetCards(params Predicate<MunicipalCard>[] inputData) => _municipalRegistry.GetCards();
    }
}
