using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, conta;

            Console.Write("digite o numero: ");
            num = int.Parse(Console.ReadLine());

            for (int x = 0; x <= 10; x++)
            {
                conta = num * x;
                Console.WriteLine("{0} X {1} = {2}", num, x, conta);
            }
            Console.ReadKey();
        }
        
    }
}
