namespace InformationSystemDesign.Interfaces
{
    internal interface IRegistry<T>
    {
        void AddCard(T card);
        void RemoveCard(T card);
        void UpdateCard(T card, params object[] inputData);
        T GetCard(int cardId);
    }
}
