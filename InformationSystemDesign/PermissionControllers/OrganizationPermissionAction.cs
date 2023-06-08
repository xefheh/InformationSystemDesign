using InformationSystemDesign.Enumerators;
using InformationSystemDesign.Initialization;
using InformationSystemDesign.Interfaces;

namespace InformationSystemDesign.PermissionControllers;

public class OrganizationPermissionAction : IPermissionAction
{
    private readonly User _user;

    public OrganizationPermissionAction(User user) => _user = user;

    public bool CanRemoveCard()
    {
        var permissions = new[] { UserType.ОператорВетСлужбы, UserType.ОператорОМСУ };
        return permissions.Any(type => type == _user.UserType);
    }

    public bool CanAddCard()
    {
        var permissions = new[] { UserType.ОператорВетСлужбы, UserType.ОператорОМСУ };
        return permissions.Any(type => type == _user.UserType);
    }

    public bool CanUpdateCard()
    {
        var permissions = new[] { UserType.ОператорВетСлужбы, UserType.ОператорОМСУ };
        return permissions.Any(type => type == _user.UserType);
    }
}