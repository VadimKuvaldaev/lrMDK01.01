using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Program
    {
        static void Main()
        {
            // Вариант 2 Кувалдаев Вадим
            Console.WriteLine("Введите размер массива: ");
            int Length = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Length];
            Console.WriteLine("Ввести элементы массива: ");
            for (int i = 0; i < Length; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("элементы массива: ");
            foreach(int element in Array)
            {
                Console.WriteLine(element);
            }
        }
    }
}
