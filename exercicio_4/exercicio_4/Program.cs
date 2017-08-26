using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,soma = 0;

            Console.Write("digite o menor numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("digite o maior numero: ");
            num2 = int.Parse(Console.ReadLine());

            for (int x = num1; x <= num2; x++)
            {
                if(x % 2 != 0)
                {
                    soma++;
                }
            }
            Console.Write("total de numeros impar: " + soma);
            Console.ReadKey();
        } 
    }
}
