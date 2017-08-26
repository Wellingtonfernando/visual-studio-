using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, fatorial = 1;

            Console.Write("Digite o numero: ");
            num = int.Parse(Console.ReadLine());

            for (int x = 1; x <= num; x++)
            {
                fatorial *= x;
            }
            Console.Write("Fatrial de {0} é: {1}", num, fatorial);
            Console.ReadKey();
        }
    }

}
