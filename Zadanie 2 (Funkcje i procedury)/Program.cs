using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2__Funkcje_i_procedury_
{
    class Program
    {
        static double max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Max 8 i 3 to: {0}",max(8, 3));
            Console.WriteLine("Max 3 i 8 to: {0}", max(3, 8));
            Console.WriteLine("Max 3 i 3 to: {0}", max(3, 3));
            Console.ReadKey();
        }
    }
}
