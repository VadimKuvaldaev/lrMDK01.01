using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Расчет площади и периметра фигур ===\n");

            List<object> shapes = new List<object>();

            shapes.Add(new Circle(5));
            shapes.Add(new Rectangle(4, 6));
            shapes.Add(new Triangle(3, 4, 5));
            shapes.Add(new Circle(2.5));
            shapes.Add(new Rectangle(3, 7));
            shapes.Add(new Triangle(5, 12, 13));

            Console.WriteLine($"Всего фигур: {shapes.Count}\n");

            Console.WriteLine("1. Расчет площадей:");
            Console.WriteLine("--------------------");

            double totalArea = 0;

            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] is Circle)
                {
                    Circle circle = (Circle)shapes[i];
                    double area = circle.CalculateArea();
                    totalArea += area;
                    Console.WriteLine($"Фигура {i + 1} (Круг): {area:F2}");
                }
                else if (shapes[i] is Rectangle)
                {
                    Rectangle rect = (Rectangle)shapes[i];
                    double area = rect.CalculateArea();
                    totalArea += area;
                    Console.WriteLine($"Фигура {i + 1} (Прямоугольник): {area:F2}");
                }
                else if (shapes[i] is Triangle)
                {
                    Triangle triangle = (Triangle)shapes[i];
                    double area = triangle.CalculateArea();
                    totalArea += area;
                    Console.WriteLine($"Фигура {i + 1} (Треугольник): {area:F2}");
                }
            }

            Console.WriteLine($"\nОбщая площадь: {totalArea:F2}");

            Console.WriteLine("\n\n2. Расчет периметров:");
            Console.WriteLine("----------------------");

            double totalPerimeter = 0;

            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] is Circle)
                {
                    Circle circle = (Circle)shapes[i];
                    double perimeter = circle.CalculatePerimeter();
                    totalPerimeter += perimeter;
                    Console.WriteLine($"Фигура {i + 1} (Круг): {perimeter:F2}");
                }
                else if (shapes[i] is Rectangle)
                {
                    Rectangle rect = (Rectangle)shapes[i];
                    double perimeter = rect.CalculatePerimeter();
                    totalPerimeter += perimeter;
                    Console.WriteLine($"Фигура {i + 1} (Прямоугольник): {perimeter:F2}");
                }
                else if (shapes[i] is Triangle)
                {
                    Triangle triangle = (Triangle)shapes[i];
                    double perimeter = triangle.CalculatePerimeter();
                    totalPerimeter += perimeter;
                    Console.WriteLine($"Фигура {i + 1} (Треугольник): {perimeter:F2}");
                }
            }

            Console.WriteLine($"\nОбщий периметр: {totalPerimeter:F2}");

            Console.WriteLine("\n\n3. Подробная информация:");
            Console.WriteLine("-------------------------");

            for (int i = 0; i < shapes.Count; i++)
            {
                Console.WriteLine($"\nФигура {i + 1}:");

                if (shapes[i] is Circle circle)
                {
                    circle.PrintInfo();
                }
                else if (shapes[i] is Rectangle rect)
                {
                    rect.PrintInfo();
                }
                else if (shapes[i] is Triangle triangle)
                {
                    triangle.PrintInfo();
                }
            }

            Console.WriteLine("\n\n4. Статистика:");
            Console.WriteLine("----------------");

            int circleCount = 0;
            int rectangleCount = 0;
            int triangleCount = 0;

            double circleArea = 0;
            double rectangleArea = 0;
            double triangleArea = 0;

            foreach (object shape in shapes)
            {
                if (shape is Circle circle)
                {
                    circleCount++;
                    circleArea += circle.CalculateArea();
                }
                else if (shape is Rectangle rect)
                {
                    rectangleCount++;
                    rectangleArea += rect.CalculateArea();
                }
                else if (shape is Triangle triangle)
                {
                    triangleCount++;
                    triangleArea += triangle.CalculateArea();
                }
            }

            Console.WriteLine($"Кругов: {circleCount}, общая площадь: {circleArea:F2}");
            Console.WriteLine($"Прямоугольников: {rectangleCount}, общая площадь: {rectangleArea:F2}");
            Console.WriteLine($"Треугольников: {triangleCount}, общая площадь: {triangleArea:F2}");            
            Console.ReadLine();
        }
    }
}
