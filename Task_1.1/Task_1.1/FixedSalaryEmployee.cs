using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    public class FixedSalaryEmployee
    {
        private int id_;
        private string fullName_;
        private string email_;
        private decimal monthlySalary_;

        public FixedSalaryEmployee(int id, string fullName, string email, decimal salary)
        {
            id_ = id;
            fullName_ = fullName;
            email_ = email;
            monthlySalary_ = salary;
        }

        public decimal CalculateSalary()
        {
            return monthlySalary_;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {id_}, Имя: {fullName_}, Email: {email_}");
            Console.WriteLine($"Фиксированная зарплата: {CalculateSalary()} руб.");
        }
    }
}
