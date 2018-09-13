using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            float n;

            Console.WriteLine("Escreva um número:");
            n = float.Parse(Console.ReadLine());

            if (n < 10 && n % 2 == 0)
                Console.WriteLine("Número par menor que dez.");
            else if (n < 10 && n % 2 != 0)
                Console.WriteLine("Número ímpar menor que dez");
            else
                Console.WriteLine("Número fora do intervalo");

            Console.ReadKey();
        }
    }
}
