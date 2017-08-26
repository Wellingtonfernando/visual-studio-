using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota;
            float media,soma = 0;

            for (int x = 1; x <= 10; x++)
            {
                do
                {
                    Console.Write("digite a nota: " + x + " ");
                    nota = int.Parse(Console.ReadLine());
                    if (nota < 0 || nota > 10)
                    {
                        Console.WriteLine("nota invalida !!!");
                    }
                }
                while (nota < 0 || nota > 10);
                soma += nota;
            }
            media = soma / 10;
            Console.Write("Média: " + media);
            Console.ReadKey();
        }
    }
}
