using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3__Tablice_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];//tablica 1000 liczb
            int i, n;
            Console.WriteLine("Podaj liczbe elementow tablicy mniejszych równych tysiąc: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("Podaj liczbe {0}: ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = n; i > 0; i--)
            {
                
                
            }
        }
    }
}
