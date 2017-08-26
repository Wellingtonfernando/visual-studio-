using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("digite o numero: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("o dobro do numero {0} é {1} ", num,(num * 2));
            Console.ReadKey();
            

        }
    }
}
