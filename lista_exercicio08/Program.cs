using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, aux;
            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            aux = a;
            a = b;
            b = aux;

            Console.WriteLine("valor de A era " + b + " agora é: " + a);
            Console.WriteLine("valor de B era " + a + " agora é: " + b);
            Console.ReadKey();
             
        }
    }
}
