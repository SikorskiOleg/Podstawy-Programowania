using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4__Pętla_while_do_while_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            Console.WriteLine("Podaj n: "); //wiersze
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj k: "); //kolumny
            int k = Convert.ToInt32(Console.ReadLine());
            i = 1; // pomocnicza wiersze
            j = 1; // pomocnicza kolumny
            while (i<=n)
            {
                j = 1; // reset kolumny
                while (j <= k)
                {
                    Console.Write("*");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
        }
    }
}
