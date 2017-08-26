using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("digite um numero: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("o numero {0} elevado ao quadrado é {1}", num, Math.Pow(num, 2));
            Console.ReadKey();
        }
    }
}
