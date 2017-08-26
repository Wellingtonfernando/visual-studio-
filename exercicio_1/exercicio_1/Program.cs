using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 11; x <= 250; x++)
            {
                if (x % 2 == 0)
                {
                    Console.WriteLine("{0}", x);

                }
            }
            Console.ReadKey();
        }
    }
}
