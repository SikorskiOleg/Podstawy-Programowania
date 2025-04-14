using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_12__Prosta_pętla_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, p=0;
            Console.Write("Podaj wysokość: ");
            h = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=h;i++)
            {
                for(int j=1;j<=i;j++)
                { 
                        p += i;
                        Console.Write(p);
                    
                }
                Console.WriteLine("");
                p = 0;
            }
            Console.ReadKey();


        }
    }
}
