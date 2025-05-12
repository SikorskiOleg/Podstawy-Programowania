using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5__Funkcje_i_procedury_
{
    class Program
    {
        static int pierwsza(int liczba)
        {
            for(int i=2; i<liczba;i++)
            {
                if (liczba % i == 0) return 0;
            }
            return 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba jest liczbą pierwszą dla wartości 1 i nie pierwszą dla wartości 0");
            Console.WriteLine("Liczba 7: {0}", pierwsza(7));
            Console.WriteLine("Liczba 28: {0}", pierwsza(28));
            Console.WriteLine("Liczba 57: {0}", pierwsza(57));
            Console.ReadKey(true);
        }
    }
}
