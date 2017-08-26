using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int x = 1; x <= 100; x++)
            {
                Console.WriteLine(x);
                if (x % 10 == 0)
                {
                    Console.WriteLine("{multiplo de 10 ");
                }
            }
            Console.ReadKey();
        }
    }
}
