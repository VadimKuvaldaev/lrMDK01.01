using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    internal class Program
    {
        /// Кувалдаев Вариант_2 Задание_1
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива: ");
            int lengthArray = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[lengthArray];
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < lengthArray; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            double sum = 0;
            foreach (int i in Array)
            {
                sum += i;
            }
            double average = sum / lengthArray;
            Console.WriteLine($"Среднее значение: {average}");
            Console.Write("Элементы меньше среднего: ");
            foreach (int element in Array)
            {
                if (element < average)
                {
                    Console.Write($"{element} ");
                }
            }
        }
    }
}
