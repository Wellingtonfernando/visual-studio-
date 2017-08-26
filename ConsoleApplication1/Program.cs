using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cidade;
            int idade;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua cidade: ");
            cidade = Console.ReadLine();

            Console.Write("{0} tem {1} e mora em {2} ", nome, idade, cidade);

            Console.ReadKey();
        }
    }
}
