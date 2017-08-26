using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.Write("digite o valor maior: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("digite o valor menor: ");
            num2 = int.Parse(Console.ReadLine());

            for (int x = num1; x >= num2; x--)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine("{0} ", x);
                }
            }
            Console.ReadKey();
        }
    }
}
