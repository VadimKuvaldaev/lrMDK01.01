using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
   public class Role
    {
        private string roleName_;
        private string[] accessibleModules_;

        public Role(string name, string[] modules)
        {
            roleName_ = name;
            accessibleModules_ = modules;
        }

        public bool HasAccessToModule(string moduleName)
        {
            for (int i = 0; i < accessibleModules_.Length; i++)
            {
                if (accessibleModules_[i] == moduleName)
                    return true;
            }
            return false;
        }

        public void Login(string employeeName)
        {
            Console.WriteLine($"{employeeName} вошел как {roleName_}");
        }
    }
}
