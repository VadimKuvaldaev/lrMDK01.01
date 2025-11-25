using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_DZ
{
    class Program
    {
        static void Main()
        {
            // Создаем матрицу 2x2
            IntMatrix m1 = new IntMatrix(2, 2);
            m1.SetValue(0, 0, 1);
            m1.SetValue(0, 1, 2);
            m1.SetValue(1, 0, 3);
            m1.SetValue(1, 1, 4);

            Console.WriteLine("Матрица 1:");
            m1.Print();

            // Создаем матрицу 2x2
            IntMatrix m2 = new IntMatrix(2, 2);
            m2.SetValue(0, 0, 5);
            m2.SetValue(0, 1, 6);
            m2.SetValue(1, 0, 7);
            m2.SetValue(1, 1, 8);

            Console.WriteLine();

            Console.WriteLine("Матрица 2:");
            m2.Print();

            Console.WriteLine();

            // Создаем матрицу 3x3
            IntMatrix m3 = new IntMatrix(3, 3);
            m3.SetValue(0, 0, 5);
            m3.SetValue(0, 1, 6);
            m3.SetValue(0, 2, 7);
            m3.SetValue(1, 0, 8);
            m3.SetValue(1, 1, 9);
            m3.SetValue(1, 2, 1);
            m3.SetValue(2, 0, 2);
            m3.SetValue(2, 1, 3);
            m3.SetValue(2, 2, 4);           

            Console.WriteLine("Матрица 3:");
            m3.Print();

            Console.WriteLine();

            // Умножаем матрицы
            IntMatrix product = IntMatrix.Multiply(m1, m2);
            Console.WriteLine("Результат умножения матрицы 1 и 2:");
            product.Print();

            Console.WriteLine();

            // Определитель
            Console.WriteLine($"Определитель матрицы 3: {m3.Determinant()}");
        }
    }
}
