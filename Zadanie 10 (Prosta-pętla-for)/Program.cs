using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10__Prosta_pętla_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 0,j;
            Console.Write("Podaj ilośc liczb naturalnych podzielnych przez 7: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0;i<=n;i++)
            {
                for (j = 1; j % 7 != 0; j++)
                {
                    suma += 1;
                    if (suma % 7 == 0)
                    {
                        Console.WriteLine(suma);
                    }
                }
                    
            }
            Console.ReadKey();
        }
    }
}
