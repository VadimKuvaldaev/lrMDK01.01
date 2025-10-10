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
            int Length = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[Length];
            Console.WriteLine("Введите элементы массива");
            for (int i =0; i < Length; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            
        }
    }
}
