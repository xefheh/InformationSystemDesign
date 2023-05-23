namespace InformationSystemDesign.Interfaces
{
    internal interface IRegistry<T>
    {
        void AddCard(T card);
        void RemoveCard(T card);
        void UpdateCard(T car, params object[] inputData);
        T GetCard(int cardId);
    }
}
