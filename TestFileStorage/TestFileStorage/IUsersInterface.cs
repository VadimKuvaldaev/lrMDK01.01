using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{ 
    interface IUsersInterface
    {
        List<User> Load();

        bool Authenticate(string login, string password);

        bool CheckExistUser(string login);

        bool AddUser( User user);
    }
}
