namespace InformationSystemDesign.Interfaces;

public interface IValidation
{
    bool IsValid(params object[] inputData);
}