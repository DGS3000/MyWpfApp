using System.Collections.Generic;
using System.Linq;

namespace MyWpfApp
{
    public class AuthLogic
    {
        private List<User> _users;

        public AuthLogic()
        {
            _users = new List<User>
            {
                new User("1", "1"),
                new User("2", "2")
            };
        }

        public bool AuthService(string login, string pass)
        {
            var user = _users.FirstOrDefault(u => u.Login == login && u.Pass == pass);
            return user != null;
        }
    }
}