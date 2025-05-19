using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        struct Osoba
        {
            public string imie, nazwisko;
            public int rok_urodzenia;
        }
        static void Main(string[] args)
        {
            Osoba o;
            Console.WriteLine("Podaj imię: ");
            o.imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            o.nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj rok urodzenia: ");
            o.rok_urodzenia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1} rok urodzenia {2}", o.imie,o.nazwisko,o.rok_urodzenia);
            Console.ReadKey(true);
        }
    }
}
