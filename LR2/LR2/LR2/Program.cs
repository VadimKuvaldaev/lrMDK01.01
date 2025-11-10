using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    internal class Program
    {
        static public void Print(List<string> games) 
        {
            Console.WriteLine("Список игр: ");
            for (int i = 0; i < games.Count; i++) 
            {
              Console.WriteLine($"{i + 1}. {games[i]}");
            }
        }
    }
}
