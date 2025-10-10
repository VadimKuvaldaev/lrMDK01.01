using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2
{
    internal class Program
    {
        /// Кувалдаев Вариант_2 Задание_2
        static void Main(string[] args)
        {
            int[] array = new int[1990];
            int a = 10;
            for (int i = 0; i < array.Length; i++) 
            {
              array[i] = a;
                ++a;
            }
            
        }
    }
}
