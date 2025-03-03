using System;

namespace Zadanie_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.Write("Podaj liczbę całkowita");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("a^3= 0}" , a*a*a);
            Console.ReadKey(true);
        }
    }
}
