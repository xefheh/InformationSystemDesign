﻿using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Enumerators;
using InformationSystemDesign.Interfaces;
using InformationSystemDesign.Registers;

namespace InformationSystemDesign.Controllers
{
    internal class AnimalRegistryController : IController<AnimalCard>   
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
            _animalRegistry.UpdateCard(card, inputData);
        }

        public BindingList<AnimalCard> GetCards(params object[] inputData) => _animalRegistry.GetCards();

    }
    public class PermissionException : Exception
    {
        public PermissionException(string message) : base(message) { }
    }
}