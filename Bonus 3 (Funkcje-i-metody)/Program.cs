using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_3__Funkcje_i_metody_
{
    class Program
    {
        static void PokazOdwrotnie(int[] tablica)
        {
            for (int i = tablica.Length - 1; i >= 0; i--)
            {
                Console.Write(tablica[i] + " ");
            }
            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            int[] tab = { 1, 2, 3, 4, 5 };
            PokazOdwrotnie(tab); // Wyświetli: 5 4 3 2 1
            Console.ReadKey();
        }
    }
}
