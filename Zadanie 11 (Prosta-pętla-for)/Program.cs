using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_11__Prosta_pętla_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, suma = 1, suma2 = 0,j;
            Console.Write("Podaj ilość początkowych liczb nieparzystych: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=n;i++)
            {
                for(j=suma;j % 2 != 0;j++)
                {
                    if(i != 1)suma += 2;
                }
                suma2 += suma;
            }
            Console.WriteLine("Suma tych liczb to: {0}", suma2);
            Console.ReadKey();
        }
    }
}
