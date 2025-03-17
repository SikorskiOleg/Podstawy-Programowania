using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3__Instrukcje_warunkowe_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("Podaj liczbe a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj liczbe c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine("A jest największa");
            else if (b > c && b > a)
                Console.WriteLine("B jest największa");
            else if (c > a && c > b)
                Console.WriteLine("C jest największa");

            if (a < b && a < c)
                Console.WriteLine("A jest najmniejsza");
            else if (b < c && b < a)
                Console.WriteLine("B jest najmniejsza");
            else if (c < a && c < b)
                Console.WriteLine("C jest najmniejsza");



            Console.ReadKey();
        }
    }
}
