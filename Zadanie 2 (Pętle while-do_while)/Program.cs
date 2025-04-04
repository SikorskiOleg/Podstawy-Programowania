using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2__Pętle_while_do_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int an, i, n;
            Console.WriteLine("Podaj liczbę wyrazów n: ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while(i<=n)
            {
                an = 2 * i - 1;
                i++;
                Console.WriteLine("Wyraz nr {0} to: {1}", i-1, an);
            }
            Console.ReadKey();

        }
    }
}
