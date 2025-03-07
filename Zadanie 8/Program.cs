using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dany jest ciag: an = 3*n-1");
            Console.Write("Podaj n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a{0} = {1}", n, 3 * n - 1);
            Console.ReadKey();
        }
    }
}
