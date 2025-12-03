using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    // Класс для круга
    class Circle
    {
        private double radius_;

        // Конструктор класса Circle
        public Circle(double radius)
        {
            radius_ = radius;
        }

        // Метод для расчета площади круга
        public double CalculateArea()
        {
            return Math.PI * radius_ * radius_;
        }

        // Метод для расчета периметра (длины окружности) круга
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius_;
        }

        // Метод для вывода информации о круге
        public void PrintInfo()
        {
            Console.WriteLine($"Круг: радиус = {radius_}");
            Console.WriteLine($"  Площадь: {CalculateArea():F2}");
            Console.WriteLine($"  Периметр: {CalculatePerimeter():F2}");
        }
    }
}
