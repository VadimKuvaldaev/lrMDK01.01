using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    public class FreelancerEmployee
    {
        private int id_;
        private string fullName_;
        private string email_;
        private decimal projectPayment_;

        public FreelancerEmployee(int id, string fullName, string email, decimal projectPayment)
        {
            id_ = id;
            fullName_ = fullName;
            email_ = email;
            projectPayment_ = projectPayment;
        }

        public decimal CalculateSalary()
        {
            decimal tax = projectPayment_ * 0.13m;
            return projectPayment_ - tax;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Сотрудник: {fullName_}");
            Console.WriteLine($"ID: {id_}, Email: {email_}");
            Console.WriteLine($"Оплата за проект: {projectPayment_} руб.");
            Console.WriteLine($"Зарплата после налога: {CalculateSalary()} руб.");
        }
    }
}
