using InformationSystemDesign.Exceptions;

namespace InformationSystemDesign.Initialization
{
    public class UserInformer
    {
        private readonly InspectionContext _context;
        public UserInformer(InspectionContext context) => _context = context;

        public User SearchUserByLogin(string login)
        {
            var user = _context.Users.Find(login);
            if (user == null) throw new InvalidLoginException();
            return user;
        }

        public User Enter(string login, string password)
        {
            var user = SearchUserByLogin(login);
            user.CheckPassword(password);
            return user;
        }
    }
}
