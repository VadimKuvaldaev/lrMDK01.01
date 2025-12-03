using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    class Rectangle
    {
        private double width_;
        private double height_;

        public Rectangle(double width, double height)
        {
            width_ = width;
            height_ = height;
        }

        public double CalculateArea()
        {
            return width_ * height_;
        }

        public double CalculatePerimeter()
        {
            return 2 * (width_ + height_);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Прямоугольник: {width_} x {height_}");
            Console.WriteLine($"  Площадь: {CalculateArea():F2}");
            Console.WriteLine($"  Периметр: {CalculatePerimeter():F2}");
        }
    }
}
