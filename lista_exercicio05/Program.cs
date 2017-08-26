using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("digite a idade");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine(idade > 17 ? "maior de idade" : "menor de idade");
            Console.ReadKey();
        }
    }
}
