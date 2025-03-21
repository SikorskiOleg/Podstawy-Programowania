using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4_Prosta_pętla_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,i,j;
            Console.Write("Podaj podstawę prostokąta: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wysokość prostokąta: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (i=1; i<=a; i++)
            {
                for (j=1; j<=b; j++)
                {
                    Console.Write("*");
                   
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
