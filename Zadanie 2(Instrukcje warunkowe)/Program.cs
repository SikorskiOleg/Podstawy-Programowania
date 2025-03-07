using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2_Instrukcje_warunkowe_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine("The number is greater than 0");
            }
            else
            {
                if (a == 0)
                {
                    Console.WriteLine("The number is equal to 0");
                }
                else
                {
                    Console.WriteLine("The number is smaller than 0");
                }



            }
            Console.ReadKey();

        }
    }
}
