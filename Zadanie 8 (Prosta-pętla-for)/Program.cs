using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8__Prosta_pętla_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, k;
            Console.Write("Podaj rok początkowy: ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj rok końcowy: ");
            k = Convert.ToInt32(Console.ReadLine());
            for(int i = p; i <=k; i++)
            {
                if(i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
