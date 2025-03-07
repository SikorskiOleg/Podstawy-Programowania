using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b; // a - first number, b - second number
            Console.Write("Podaj liczbę a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj liczbę b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Suma: {0}", a + b);
            Console.WriteLine("Różnica: {0}", a - b);
            Console.WriteLine("Iloczyn: {0}", a * b);
            Console.WriteLine("Iloraz: {0}", a / b);
            Console.ReadKey();

        }
    }
}
