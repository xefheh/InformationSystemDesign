using InformationSystemDesign.Enumerators;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.PermissionControllers;

public class AnimalPermissionAction : IPermissionAction
{
    private readonly User _user;
    public AnimalPermissionAction(User user) => _user = user;

    public bool CanRemoveCard()
    {
        var permissions = new[] { UserType.ВетВрач, UserType.ВетВрачПриюта, UserType.ОператорПриюта };
        return permissions.Any(type => type == _user.UserType);
    }

    public bool CanAddCard()
    {
        var permissions = new[] { UserType.ВетВрач, UserType.ВетВрачПриюта, UserType.ОператорПриюта };
        return permissions.Any(type => type == _user.UserType);
    }

    public bool CanUpdateCard()
    {
        var permissions = new[] { UserType.ВетВрач, UserType.ВетВрачПриюта, UserType.ОператорПриюта };
        return permissions.Any(type => type == _user.UserType);
    }
}