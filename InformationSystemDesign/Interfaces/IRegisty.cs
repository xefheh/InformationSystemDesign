using System.ComponentModel;
using InformationSystemDesign.Cards;

namespace InformationSystemDesign.Interfaces
{
    public interface IRegistry<T>
    {
        void AddCard(T card);
        void RemoveCard(T card);
        void UpdateCard(T card, params object[] inputData);
        T GetCard(int cardId);
        BindingList<T> GetCards();
    }
}
