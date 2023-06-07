using System.ComponentModel;

namespace InformationSystemDesign.Interfaces
{
    public interface IController<T>
    {
        void AddCard(params object[] inputData);
        void RemoveCard(T card);
        void UpdateCard(T card, params object[] updatedData);
        BindingList<T> GetCards(params Predicate<T>[] filter);
        T GetCard(object identity);
    }
}
