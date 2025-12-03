using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    class Triangle
    {
        private double sideA_;
        private double sideB_;
        private double sideC_;

        public Triangle(double a, double b, double c)
        {
            sideA_ = a;
            sideB_ = b;
            sideC_ = c;
        }

        public double CalculateArea()
        {
            double p = (sideA_ + sideB_ + sideC_) / 2;
            return Math.Sqrt(p * (p - sideA_) * (p - sideB_) * (p - sideC_));
        }

        public double CalculatePerimeter()
        {
            return sideA_ + sideB_ + sideC_;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Треугольник: стороны {sideA_}, {sideB_}, {sideC_}");
            Console.WriteLine($"  Площадь: {CalculateArea():F2}");
            Console.WriteLine($"  Периметр: {CalculatePerimeter():F2}");
        }
    }
}
