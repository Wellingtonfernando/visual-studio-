using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,maior = 0;

            for(int x = 1; x <= 15; x++)
            {
                Console.Write("digite o numero " + x + " ")
                num = int.Parse(Console.ReadLine());
                if (x == 0) { maior = num; }
                if (num > maior)
                {
                    maior = num;
                }
            }
            Console.Write("maior numero digitado: " + maior);
            Console.ReadKey();
        }
    }
}
