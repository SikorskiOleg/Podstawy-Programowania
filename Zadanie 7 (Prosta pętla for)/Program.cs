using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7__Prosta_pętla_for_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 13) == 0)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
