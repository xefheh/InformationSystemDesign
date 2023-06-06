using InformationSystemDesign.Enumerators;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.PermissionControllers;

public class MunicipalPermissionAction : IPermissionAction
{
    private readonly User _user;
    public MunicipalPermissionAction(User user) => _user = user;

    public bool CanRemoveCard()
    {
        var permissions = new[] { UserType.ОператорОМСУ };
        return permissions.Any(type => type == _user.UserType);
    }

    public bool CanAddCard()
    {
        var permissions = new[] { UserType.ОператорОМСУ };
        return permissions.Any(type => type == _user.UserType);
    }

    public bool CanUpdateCard()
    {
        var permissions = new[] { UserType.ОператорОМСУ };
        return permissions.Any(type => type == _user.UserType);
    }
}