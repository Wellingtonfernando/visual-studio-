using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            Console.WriteLine("Digite o primeiro nome");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo nome");
            nome2 = Console.ReadLine();

            Console.WriteLine(nome1 + "em maiusculo: " + nome1.ToUpper());
            Console.WriteLine(nome2 + "em maiusculo: " + nome2.ToUpper());

            Console.WriteLine(nome1 + "possui " + nome1.Length + " caracteres");
            Console.WriteLine(nome2 + "possui " + nome2.Length + " caracteres");

            Console.WriteLine("primeiras 3 letras do nome " + nome1 + " são: " + nome1.Substring(0, 3));
            Console.WriteLine("primeiras 3 letras do nome " + nome2 + " são: " + nome2.Substring(0, 3));
            Console.ReadKey();
        }
    }
}
