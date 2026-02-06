using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace TestFileStorage
{
    public class FileUsersStorage : IUsersInterface
    {
        public List<User> Load()
        {
            List<User> result = new List<User>();
            using (StreamReader reader = new StreamReader("TestFileStorage.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] userInfo = line.Split('-');
                    User user = new User(userInfo[0], userInfo[1]);
                    result.Add(user);
                }
            }
            return result;
        }
        public bool CheckExistUser(string Login) 
        {
            List<User> users = Load();            
            foreach (User user in users)
            {
                if (Login == user.Login)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddUser(User user)
        {
            using (StreamWriter writer = new StreamWriter("TestFileStorage.txt", true))
            {
                 writer.WriteAsync("");
                 
            }
        }
    }
}
