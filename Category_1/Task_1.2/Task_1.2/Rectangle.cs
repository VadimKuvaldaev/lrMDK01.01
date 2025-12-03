using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    // Класс для прямоугольника
    class Rectangle
    {
        private double width_;
        private double height_;

        // Конструктор класса Rectangle
        public Rectangle(double width, double height)
        {
            width_ = width;
            height_ = height;
        }

        // Метод для расчета площади прямоугольника
        public double CalculateArea()
        {
            return width_ * height_;
        }

        // Метод для расчета периметра прямоугольника
        public double CalculatePerimeter()
        {
            return 2 * (width_ + height_);
        }

        // Метод для вывода информации о прямоугольнике
        public void PrintInfo()
        {
            Console.WriteLine($"Прямоугольник: {width_} x {height_}");
            Console.WriteLine($"  Площадь: {CalculateArea():F2}");
            Console.WriteLine($"  Периметр: {CalculatePerimeter():F2}");
        }
    }
}
