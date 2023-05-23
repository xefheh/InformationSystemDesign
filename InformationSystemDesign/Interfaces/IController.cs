namespace InformationSystemDesign.Interfaces
{
    internal interface IController<T>
    {
        void AddCard(params object[] inputData);
        void RemoveCard(T card);
        void UpdateCard(T card, params object[] updatedData);
        IEnumerable<T> GetCards(params object[] filter);
        T GetCard(int cardId);
    }
}
