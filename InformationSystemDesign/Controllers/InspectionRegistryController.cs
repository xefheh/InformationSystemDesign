using System.ComponentModel;
using InformationSystemDesign.Cards;
using InformationSystemDesign.Exceptions;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.Controllers;

public class InspectionRegistryController : IController<InspectionCard>, IValidation
{
    private readonly IRegistry<InspectionCard> _registry;
    private readonly IPermissionAction _permissionAction;

    public InspectionRegistryController(IRegistry<InspectionCard> registry, IPermissionAction permissionAction)
    {
        _registry = registry;
        _permissionAction = permissionAction;
    }

    public BindingList<InspectionCard> GetCards() => _registry.GetCards();

    public void AddCard(params object[] inputData)
    {
        if (!_permissionAction.CanAddCard()) throw new PermissionException("Can`t add card!");
        if (!IsValid(inputData)) throw new ValidationException("No valid data!");
        _registry.AddCard(inputData);
    }

    public void UpdateCard(InspectionCard card, object[] inputData)
    {
        if (!_permissionAction.CanUpdateCard()) throw new PermissionException("Can`t update card!");
        if (!IsValid(inputData)) throw new ValidationException("No valid data!");
        _registry.UpdateCard(card, inputData);
    }

    public void RemoveCard(InspectionCard card)
    {
        if (!_permissionAction.CanRemoveCard()) throw new PermissionException("Can`t remove card!");
        _registry.RemoveCard(card);
    }

    public InspectionCard GetCard(object id) => _registry.GetCard(id);

    public bool IsValid(params object[] inputData)
    {
        return inputData.All(property => property is not (string and ""));
    }
}