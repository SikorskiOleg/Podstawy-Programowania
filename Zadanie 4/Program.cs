using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            Console.Write("Podaj podstawe prostokata: ");
                a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wysokosc prostokata: ");
                b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pole prostokąta to: {0}", a*b);
            Console.Write(" Obwód prostokąta to: {0}", 2 * a + 2 * b);
            Console.ReadKey();
        }
    }
}
