namespace InformationSystemDesign.Interfaces
{
    internal interface IRegistry<T>
    {
        void AddCard(params object[] inputData);
        void RemoveCard(T inputData);
        void UpdateCard(T car, params object[] inputData);
        T GetCard(int cardId);
    }
}
