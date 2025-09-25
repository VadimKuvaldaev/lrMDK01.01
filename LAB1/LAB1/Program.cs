using System;
using System.Collections.Generic;
using System.Globalization;
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
            Console.WriteLine("Введите элементы массива: ");
            for (int i = 0; i < Length; i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }            
            int sum = 0;  
            foreach(int i in Array) 
            {
                sum += i;
            }
            double avarage = (double)sum / Length; 
            Console.WriteLine($"Среднее значение: {avarage}");
        }
    }
}
