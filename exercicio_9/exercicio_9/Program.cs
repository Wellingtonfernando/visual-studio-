using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,cont_par = 0, cont_impar = 0,cont_positivo = 0,cont_negativo = 0;
            string resp;
            do
            {
                Console.WriteLine("Digite o numero: ");
                num = int.Parse(Console.ReadLine());
                Console.WriteLine("deseja continuar S/N ???");
                resp = Console.ReadLine();
                if (num < 0)
                {
                    cont_negativo++;
                }
                else if (num > 0)
                {
                    cont_positivo++;
                }
                if(num % 2 == 0)
                {
                    cont_par++;
                }
                else if (num % 2 != 0)
                {
                    cont_impar++;
                }
                 
            }
            while (resp == "s" || resp == "S");
            Console.WriteLine("Numeros positivos: " + cont_positivo);
            Console.WriteLine("Numeros negativos: " + cont_negativo);
            Console.WriteLine("Numeros pares: " + cont_par);
            Console.WriteLine("Numeros impares: " + cont_impar);
            Console.ReadKey();
        }
    }
}
