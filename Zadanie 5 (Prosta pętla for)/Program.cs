using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5__Prosta_pętla_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,h,i,j;
            Console.Write("Podaj podstawę trójkąta: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj wysokość trójkąta: ");
            h = Convert.ToInt32(Console.ReadLine());
            for (i =1; i<=h;i++)
            {
                for(j=1;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
