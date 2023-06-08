using InformationSystemDesign.Enumerators;
using InformationSystemDesign.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace InformationSystemDesign.Initialization;

[PrimaryKey(nameof(Login))]
public class User
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string FullName { get; set; }

    public UserType UserType { get; set; }

    public bool CheckPassword(string password)
    {
        if (Password != password) throw new InvalidPasswordException();
        return true;
    }
}