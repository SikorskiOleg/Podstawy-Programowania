using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5__Instrukcje_warunkowe_
{
    class Program
    {
        static void Main(string[] args)
        {
            int rok;
            Console.Write("Podaj rok: ");
            rok = Convert.ToInt32(Console.ReadLine());
            if (rok % 4 == 0 && rok % 100 != 0 || rok % 400 == 0)
                Console.WriteLine("Rok jest przestępny");
            else
            {
                Console.WriteLine("Rok jest nie przestępny");
            }
            Console.ReadKey();

        }
    }
}