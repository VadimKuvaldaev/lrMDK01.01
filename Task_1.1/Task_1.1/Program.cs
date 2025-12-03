using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Учетная система сотрудников \n");

            // 1. СОЗДАЕМ СОТРУДНИКОВ РАЗНЫХ ТИПОВ
            Console.WriteLine("1. Информация о сотрудниках:");
            Console.WriteLine("----------------------------");

            FixedSalaryEmployee emp1 = new FixedSalaryEmployee(1, "Артем Калюжный", "artem@company.com", 500000);
            HourlySalaryEmployee emp2 = new HourlySalaryEmployee(2, "Петр Петров", "petr@company.com", 500, 160);
            FreelancerEmployee emp3 = new FreelancerEmployee(3, "Анна Сидорова", "anna@freelance.com", 100000);

            // Выводим информацию о каждом сотруднике
            Console.WriteLine("\n--- Сотрудник с фиксированной зарплатой ---");
            emp1.PrintInfo();

            Console.WriteLine("\n--- Сотрудник с почасовой оплатой ---");
            emp2.PrintInfo();

            Console.WriteLine("\n--- Фрилансер ---");
            emp3.PrintInfo();

            // 2. РАБОТА С РОЛЯМИ
            Console.WriteLine("\n\n2. Система доступа по ролям: ");
            Console.WriteLine("----------------------------");

            // Создаем роли
            Role managerRole = new Role("Менеджер", new string[] { "отчеты", "сотрудники", "зарплаты" });
            Role developerRole = new Role("Разработчик", new string[] { "код", "баги", "тесты" });
            Role accountantRole = new Role("Бухгалтер", new string[] { "финансы", "налоги", "зарплаты" });

            // Создаем сотрудников с ролями
            EmployeeWithRole emp4 = new EmployeeWithRole(4, "Сергей Сергеев", "sergey@company.com", 60000, managerRole);
            EmployeeWithRole emp5 = new EmployeeWithRole(5, "Мария Петрова", "maria@company.com", 55000, developerRole);
            EmployeeWithRole emp6 = new EmployeeWithRole(6, "Ольга Смирнова", "olga@company.com", 52000, accountantRole);

            // Тестируем доступ
            Console.WriteLine("\n--- Менеджер ---");
            emp4.LoginToSystem();
            emp4.CheckAccess("отчеты");
            emp4.CheckAccess("код");

            Console.WriteLine("\n--- Разработчик ---");
            emp5.LoginToSystem();
            emp5.CheckAccess("код");
            emp5.CheckAccess("финансы");

            Console.WriteLine("\n--- Бухгалтер ---");
            emp6.LoginToSystem();
            emp6.CheckAccess("налоги");
            emp6.CheckAccess("баги");

            // 3. РАСЧЕТ ОБЩЕЙ СУММЫ ЗАРПЛАТ
            Console.WriteLine("\n\n3. Финансовый отчет: ");
            Console.WriteLine("---------------------");

            // Создаем массивы для каждого типа сотрудников
            FixedSalaryEmployee[] fixedEmployees = { emp1 };
            HourlySalaryEmployee[] hourlyEmployees = { emp2 };
            FreelancerEmployee[] freelancerEmployees = { emp3 };
            EmployeeWithRole[] roleEmployees = { emp5, emp6 };

            decimal totalSalary = 0;
            int employeeCount = 0;

            // Считаем фиксированные зарплаты
            Console.WriteLine("\nСотрудники с фиксированной зарплатой:");
            for (int i = 0; i < fixedEmployees.Length; i++)
            {
                decimal salary = fixedEmployees[i].CalculateSalary();
                totalSalary += salary;
                employeeCount++;
                Console.WriteLine($"  Сотрудник {employeeCount}: {salary} руб.");
            }

            // Считаем почасовые зарплаты
            Console.WriteLine("\nСотрудники с почасовой оплатой:");
            for (int i = 0; i < hourlyEmployees.Length; i++)
            {
                decimal salary = hourlyEmployees[i].CalculateSalary();
                totalSalary += salary;
                employeeCount++;
                Console.WriteLine($"  Сотрудник {employeeCount}: {salary} руб.");
            }

            // Считаем зарплаты фрилансеров
            Console.WriteLine("\nФрилансеры:");
            for (int i = 0; i < freelancerEmployees.Length; i++)
            {
                decimal salary = freelancerEmployees[i].CalculateSalary();
                totalSalary += salary;
                employeeCount++;
                Console.WriteLine($"  Сотрудник {employeeCount}: {salary} руб.");
            }

            // Считаем зарплаты сотрудников с ролями
            Console.WriteLine("\nСотрудники с ролями:");
            for (int i = 0; i < roleEmployees.Length; i++)
            {
                decimal salary = roleEmployees[i].CalculateSalary();
                totalSalary += salary;
                employeeCount++;
                Console.WriteLine($"  Сотрудник {employeeCount}: {salary} руб.");
            }

            // Выводим итоги
            Console.WriteLine("\n==================================");
            Console.WriteLine($"Общее количество сотрудников: {employeeCount}");
            Console.WriteLine($"Общая сумма зарплат: {totalSalary} руб.");
            Console.WriteLine($"Средняя зарплата: {totalSalary / employeeCount:F0} руб.");

            
            Console.ReadLine();
        }
    }
}
