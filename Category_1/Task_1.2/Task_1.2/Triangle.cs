using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    // Класс для треугольника
    class Triangle
    {
        private double sideA_;
        private double sideB_;
        private double sideC_;

        // Конструктор класса Triangle
        public Triangle(double a, double b, double c)
        {
            sideA_ = a;
            sideB_ = b;
            sideC_ = c;
        }

        // Метод для расчета площади треугольника по формуле Герона
        public double CalculateArea()
        {
            double p = (sideA_ + sideB_ + sideC_) / 2;
            return Math.Sqrt(p * (p - sideA_) * (p - sideB_) * (p - sideC_));
        }

        // Метод для расчета периметра треугольника
        public double CalculatePerimeter()
        {
            return sideA_ + sideB_ + sideC_;
        }

        // Метод для вывода информации о треугольнике
        public void PrintInfo()
        {
            Console.WriteLine($"Треугольник: стороны {sideA_}, {sideB_}, {sideC_}");
            Console.WriteLine($"  Площадь: {CalculateArea():F2}");
            Console.WriteLine($"  Периметр: {CalculatePerimeter():F2}");
        }
    }
}
