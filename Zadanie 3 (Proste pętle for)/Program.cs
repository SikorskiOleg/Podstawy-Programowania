using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3__Proste_pętle_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma =0;
            Console.WriteLine("Podaj liczbę n większą od 2: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            Console.WriteLine("Suma liczb od 1 do {0} wynosi {1}", n, suma);
            Console.ReadKey();
        }
    }
}
