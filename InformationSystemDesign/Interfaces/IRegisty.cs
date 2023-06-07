using System;
using System.ComponentModel;

namespace InformationSystemDesign.Interfaces
{
    public interface IRegistry<T>
    {
        T CreateCard(params object[] inputData);
        void UpdateCardValues(T card, params object[] inputData);
        void AddCard(params object[] inputData);
        void RemoveCard(T card);
        void UpdateCard(T card, params object[] inputData);
        T GetCard(object identity);
        BindingList<T> GetCards(params Predicate<T>[] filters);
    }
}
