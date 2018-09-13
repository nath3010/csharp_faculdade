using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;

            Console.WriteLine("Escreva um número:");
            x = float.Parse(Console.ReadLine());

            if (x >= 0 && x < 100)
                Console.WriteLine("x está entre 0 e 100");
            else if (x >= 100 && x < 1000)
                Console.WriteLine("x está entre 100 e 1000 ");
            else if (x >= 1000)
                Console.WriteLine("x é maior que 1000");
            else
                Console.WriteLine("x é menor que 0");

            Console.ReadKey();
        }
    }
}
