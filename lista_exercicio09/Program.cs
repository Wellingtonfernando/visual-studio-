using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z;
            bool expressao;
            Console.WriteLine("Digite o valor de W: ");
            w = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Y: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de Z: ");
            z = int.Parse(Console.ReadLine());

            expressao = ((x >= y) && (z <= x) || (x == w) && (y == z) || (!(x != w)));

            Console.Write("Resultado é: " + expressao);
            Console.ReadKey();
        }
    }
}
