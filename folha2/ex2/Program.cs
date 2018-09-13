using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, s;
            Console.WriteLine("Número um:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número dois:");
            n2 = double.Parse(Console.ReadLine());
            s = n1 + n2;



            if (s > 15)
            {
                Console.WriteLine("O resultado a soma é: {0:0.00}", s);

            }
            else
            {
                Console.WriteLine("A soma é menor que 15!");
            }

            Console.ReadKey();



        }
    }
}
