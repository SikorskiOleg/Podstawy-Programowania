using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3__Pętla_while_do_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int i = a;
            int suma = 0;
            while (i <= b)
            {
               suma += i;
               i++;
            }
            Console.WriteLine("Suma liczb od {0} do {1} wynosi: {2}", a, b, suma);
            Console.ReadKey();
        }
    }
}
