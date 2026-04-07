using CreditLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Credit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Tigervod Ivanov = new Tigervod("Ivanov", 36, 40000);
            Tigervod a = new Tigervod("a", 30, 60000);
            Tigervod b = new Tigervod("b", 25, 45000);
            Tigervod c = new Tigervod("c", 50, 70000);
            Console.WriteLine(Ivanov.FullName());

            List<Tigervod> tigervods = new List<Tigervod>();
            tigervods.Add(a);
            tigervods.Add(b);
            tigervods.Add(c);
            Console.WriteLine(b.FullName());

            
        }
       public static void SalaryBiggerThenX(List<Tigervod> tigervods) 
       {

            foreach (Tigervod t in tigervods) 
            {
                if(t.Cell() > 50000) 
                {
                    Console.WriteLine(t.FullName());
                }
            } 
       }
    }
}
