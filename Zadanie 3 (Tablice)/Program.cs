using System;
using System.CodeDom.Compiler;
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
            int temp;
            Console.WriteLine("Podaj liczbe elementow tablicy mniejszych równych tysiąc: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj liczbe {0}: ", i+1);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            //sortowanie
            for (i = 0; i<n; i++)
            {
                for (int j = i+1; j < n; j++)
                {
                    if (tab[i] > tab[j])
                    { temp = tab[i]; tab[i] = tab[j]; tab[j] = temp; }
                }  
            }
            //koniec sortowania
            Console.WriteLine("Liczby posortowane niemalejąco: ");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", tab[i]);
            }
                
                Console.ReadKey();
        }
        
    }
}
