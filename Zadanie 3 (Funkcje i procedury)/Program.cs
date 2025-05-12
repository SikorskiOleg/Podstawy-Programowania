using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3__Funkcje_i_procedury_
{
    class Program
    {
        static double pole(double r)
        {
            return Math.PI * r * r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Pole koła o promieniu 4 to: {0}", pole(4));
            Console.ReadKey();
        }
    }
}
