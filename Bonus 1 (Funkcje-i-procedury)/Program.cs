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
        static int roznica_tablic(int[,] tab1, int[,] tab2,int wiersz,int kolumna)
        {
            if (wiersz < 0 || wiersz > tab1.GetLength(0) || kolumna < 0 || kolumna > tab1.GetLength(1)) 
            { Console.WriteLine("Niepoprawne dane"); }
            return tab1[wiersz, kolumna] - tab2[wiersz, kolumna];
        }
        static void Main(string[] args)
        {
           
            
        }
    }
}
