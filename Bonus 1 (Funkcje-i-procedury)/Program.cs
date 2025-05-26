using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_1__Funkcje_i_procedury_
{
    class Program
    {
        static void roznica_tablic(int[,] tab1, int[,] tab2)
        {
            int i, j, n, roznica;
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    roznica = tab1[i, j] - tab2[i, j];
                    Console.Write("Różnica wartości komórek: [{0}] [{1}] tych tabel to: {2}", i + 1, j + 1, roznica);
                }
            }
        }
        static void Main(string[] args)
        {
            int n, i, j;
            Console.Write("Podaj wielkość symetrycznych tablic: ");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] tab1 = new int[n, n];
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.Write("Podaj wartości tabeli 1: [{0}] [{1}]", i+1, j+1);
                    tab1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            foreach (int liczba in tab1)
            {
                Console.WriteLine(tab1[i, j]);
            }
            Console.ReadKey();
            
        }
    }
}
