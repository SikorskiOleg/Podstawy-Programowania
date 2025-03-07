using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b; // a - first number, b - second number
            Console.Write("Podaj liczbę a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbę b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Suma kwadratów a  i b to {0}", a*a + b*b);
            Console.ReadKey();
        }
    }
}
