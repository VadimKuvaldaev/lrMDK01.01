using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewLib.ModelViews
{
    public class User
    {
        private string login_;
        private string password_;
        private string name_;

        public User()
        {
        }

        public User(string login, string password, string name) 
        {
            login_ = login;
            password_ = password;
            name_ = name;
        }
        public string Login 
        {
            get { return login_; }
            set { login_ = value; }
        }
        public string Password 
        {
            get { return password_; }
            set {  password_ = value; }
        }
        public string Name 
        {
            get { return name_; }
            set { name_ = value; }
        }
    }
}
