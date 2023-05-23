namespace InformationSystemDesign.Interfaces
{
    internal interface IController<T>
    {
        void AddCard(params object[] inputData);
        void RemoveCard(T card);
        void UpdateCard(T card, params object[] updatedData);
        IRegistry<T> GetRepository();
        T GetCard(int cardId);
    }
}
