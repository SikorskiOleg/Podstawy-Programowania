using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4__Funkcje_i_procedury_
{
    class Program
    {
        static int ile_cyfr(int liczba)
        {
            int i = 0;
            while(liczba / 10 > 0)
            {
                liczba /= 10;
                i++;
            }
            return i + 1;

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("W funkcji jest {0} liczb.", ile_cyfr(0));
            Console.WriteLine("W funkcji jest {0} liczb.", ile_cyfr(3453423));
            Console.WriteLine("W funkcji jest {0} liczb.", ile_cyfr(1234));
            Console.ReadKey(true);
        }
    }
}
