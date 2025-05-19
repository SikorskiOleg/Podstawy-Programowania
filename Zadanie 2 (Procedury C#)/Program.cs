using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_2__Procedury_C__
{
    class Program
    {
        struct Uczen
        {
            public string imie, nazwisko;
            public byte[] ocena;
        }
        static void Main(string[] args)
        {
            Uczen[] uczniowie;
            int ilu_uczniow, ile_ocen, i,j; //zmienne pomocnicze
            //wczytuje liczbe uczniow
            Console.Write("Podaj ilość uczniów w klasie: ");
            ilu_uczniow = Convert.ToInt32(Console.ReadLine());
            //przydziela pamięć do tablicy struktur
            uczniowie = new Uczen[ilu_uczniow];
            //wczytuje dane uczniow od uzytkownika
            for (i = 0; i < ilu_uczniow; i++)
            {
                Console.Write("Podaj imię ucznia {0}: ", i + 1);
                uczniowie[i].imie = Console.ReadLine();
                Console.Write("Podaj imię nazwisko {0}: ", i + 1);
                uczniowie[i].nazwisko = Console.ReadLine();
                //wczytuje liczbe ocen ucznia
                Console.Write("Ile ocen ma: {0} {1}: ", uczniowie[i].imie, uczniowie[i].nazwisko);
                ile_ocen = Convert.ToInt32(Console.ReadLine());
                //przydzielam pamięć dla talbicy ocen
                uczniowie[i].ocena = new byte[ile_ocen];     
                //wczytuje oceny ucznia
                for (j=0; j < ile_ocen; j++)
                {
                    Console.WriteLine("Podaj ocenę {0}: ", i + 1);
                    uczniowie[i].ocena[j] = Convert.ToByte(Console.ReadLine());
                }
                Console.WriteLine();
            }
            //wypisuje dane uczniów na ekranie
            for (i=0; i < ilu_uczniow; i++)
            {
                Console.Write("{0}.{1} {2}: ", i + 1, uczniowie[i].imie, uczniowie[i].nazwisko);
                foreach (byte o in uczniowie[i].ocena)
                    Console.Write("{0}, ", o);
                Console.WriteLine("");//przejscie do nowego wiersza
            }
            Console.ReadKey(true);
        }           
    }
}
