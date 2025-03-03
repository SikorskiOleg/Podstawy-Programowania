using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string imie; //deklaracja zmiennej
            Console.WriteLine("Podaj swoje imie:  "); //tekst
            imie = Console.ReadLine(); // wpisanie wartosci zmiennej
            Console.WriteLine("Witaj {0}!", imie); //wpisanie imienia z wiadomością, {0} - przerwa po przecinku jej zawartosc
            Console.ReadKey(true); //pauza
        }
    }
}
