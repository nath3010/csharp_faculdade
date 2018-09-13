using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, m;

            Console.WriteLine("Número um:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número dois:");
            n2 = double.Parse(Console.ReadLine());
            m = n1 * n2;

            if (m >= 50 && m <= 100)
            {
                Console.WriteLine("O resultado a multiplicação é:{0:0.00}", m);
            }
            else
                Console.WriteLine("O valor não está entre 50 é 100!");

            Console.ReadKey();
        }
    }
}
