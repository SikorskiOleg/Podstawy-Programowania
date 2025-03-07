using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, h, l; // r - radius, h - height, l - length
            Console.WriteLine("Podaj promień podstawy: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Podaj wysokość stozka: ");
            h = Convert.ToDouble(Console.ReadLine());
            l = Math.Sqrt(r * r + h * h);
            Console.WriteLine("Pole powierzchni stozka: {0}", Math.PI * r * (r + l));
            Console.WriteLine("Objętość stozka: {0}", Math.PI * r * r * h / 3);
            Console.ReadKey();
        }
    }
}
