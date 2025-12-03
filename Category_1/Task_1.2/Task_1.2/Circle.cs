using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    class Circle
    {
        private double radius_;

        public Circle(double radius)
        {
            radius_ = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius_ * radius_;
        }

        public double CalculatePerimeter()
        {
            return 2 * Math.PI * radius_;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Круг: радиус = {radius_}");
            Console.WriteLine($"  Площадь: {CalculateArea():F2}");
            Console.WriteLine($"  Периметр: {CalculatePerimeter():F2}");
        }
    }
}
