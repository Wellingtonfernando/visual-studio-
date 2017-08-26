using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            double reais, cotacao, total;
            Console.WriteLine("Reais (R$)");
            reais = double.Parse(Console.ReadLine());
            Console.WriteLine("cotação do dolar");
            cotacao = double.Parse(Console.ReadLine());


            total = reais / cotacao;
            Console.WriteLine("Valor total: " + total);
            Console.ReadKey();
        }
    }
}
