using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
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
            Console.WriteLine("a/b = {0} r{1}",a/b, a%b );
            Console.ReadKey();
        }
    }
}
