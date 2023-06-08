using System.ComponentModel;

namespace InformationSystemDesign.Interfaces
{
    public interface IController<T>
    {
        void AddCard(params object[] inputData);
        void RemoveCard(T card);
        void UpdateCard(T card, params object[] updatedData);
        T GetCard(object identity);
        BindingList<T> GetCards();
    }
}
