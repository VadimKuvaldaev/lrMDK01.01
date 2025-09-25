using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    class Program
    {
        static void Main()
        {
            /// Вариант 2 Кувалдаев Вадим
            int[] Array = new int[1990];
            for(int i = 0; i < Array.Length; i++) 
            {
                Array[i] = 10 + i;
            }
            Console.WriteLine("[");
            for(int i =0; i < Array.Length; i++) 
            {
                Console.Write(Array[i] + ",");
            }
            Console.WriteLine(Array.Length + 10 + "]");
        }
    }
}
