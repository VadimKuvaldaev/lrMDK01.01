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

        bool CheckExistUser(string User);

        bool AddUser( User user);
    }
}
