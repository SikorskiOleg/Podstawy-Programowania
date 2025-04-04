using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5__Pętle_while_do_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            do
            {
                Console.WriteLine("Podaj x: ");
                x = Convert.ToInt32(Console.ReadLine());
            } while (x < 0);
            Console.WriteLine("Podano liczbę dodatnią: {0}", x);
            Console.ReadKey();
        }
    }
}
