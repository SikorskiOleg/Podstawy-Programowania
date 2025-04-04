using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_4__Tablice_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];//tablica 1000 liczb
            int i, n;
            int suma=0;
            Console.WriteLine("Podaj liczbe elementow tablicy mniejszych równych tysiąc: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbe {0}: ", i + 1);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            //suma
            for (i = 0; i < n; i++)
            {
                suma += tab[i];
            }
            //koniec sumowania
            Console.WriteLine("Suma wynosi: {0}", suma);
            Console.ReadKey();
        }
    }
}
