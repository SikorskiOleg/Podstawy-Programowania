using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2__Tablice_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000]; //tablica 1000 liczb
            Console.WriteLine("Podaj liczbe elementow tablicy mniejszych równych tysiąc: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i <= n; i++)
            {
                Console.WriteLine("Podaj liczbe {0}: ", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i =n; i>0;i--)
            {
                Console.WriteLine("Liczba {0} to: {1}", i, tab[i]);
            }
            Console.ReadKey();
        }
    }
}
