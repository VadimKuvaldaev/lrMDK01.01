using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    public class HourlySalaryEmployee
    {
        private int id_;
        private string fullName_;
        private string email_;
        private decimal hourlyRate_;
        private int hoursWorked_;

        public HourlySalaryEmployee(int id, string fullName, string email,
                                    decimal rate, int hours)
        {
            id_ = id;
            fullName_ = fullName;
            email_ = email;
            hourlyRate_ = rate;
            hoursWorked_ = hours;
        }

        public decimal CalculateSalary()
        {
            return hourlyRate_ * hoursWorked_;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {id_}, Имя: {fullName_}, Email: {email_}");
            Console.WriteLine($"Почасовая ставка: {hourlyRate_} руб./час, Отработано: {hoursWorked_} часов");
            Console.WriteLine($"Зарплата: {CalculateSalary()} руб.");
        }
    }
}
