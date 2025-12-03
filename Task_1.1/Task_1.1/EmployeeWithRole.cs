using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    public class EmployeeWithRole
    {
        private int id_;
        private string fullName_;
        private string email_;
        private decimal salary_;
        private Role role_;

        public EmployeeWithRole(int id, string fullName, string email,
                               decimal salary, Role role)
        {
            id_ = id;
            fullName_ = fullName;
            email_ = email;
            salary_ = salary;
            role_ = role;
        }

        public decimal CalculateSalary()
        {
            return salary_;
        }

        public void LoginToSystem()
        {
            role_.Login("Сотрудник");
        }

        public void CheckAccess(string moduleName)
        {
            if (role_.HasAccessToModule(moduleName))
                Console.WriteLine($"Доступ к '{moduleName}' есть");
            else
                Console.WriteLine($"Доступа к '{moduleName}' нет");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {id_}, Имя: {fullName_}, Email: {email_}");
            Console.WriteLine($"Зарплата: {CalculateSalary()} руб.");
        }
    }
}
