using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_2__Funkcje_i_procedury_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab1 = { 1, 2, 3 };
            int[] tab2 = { 4, 5, 6 };

            int[] wynik = laczenie(tab1, tab2);

            Console.WriteLine("Scalona tablica:");
            foreach (int liczba in wynik)
            {
                Console.Write(liczba + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static int[] laczenie(int[] tab1, int[] tab2)
        {
            int[] tab3 = new int[tab1.Length + tab2.Length];
            for (int i = 0; i < tab1.Length; i++)
            {
                tab3[i] = tab1[i];
            }
            for (int i = 0; i < tab2.Length; i++)
            {
                tab3[tab1.Length + i] = tab2[i];
            }
            return tab3;
        }
    }
}
