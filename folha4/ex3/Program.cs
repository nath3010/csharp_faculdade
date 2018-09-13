using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.WriteLine("Valor de a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor de c:");
            c = double.Parse(Console.ReadLine());

            if (a != 0)
            {
                delta = (b * b) - (4 * a * c);

                if (delta >= 0)
                {
                    x1 = ((-b) + Math.Sqrt(delta)) / (a * 2);
                    x2 = ((-b) - Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine(" Delta: {0}\n x1: {1}\n x2: {2}", delta, x1, x2);
                }

                else
                {
                    Console.WriteLine("Delta menor que zero!!");
                }
            }
            else {
                Console.WriteLine("a não pode ser 0!");
            
            }

            
              Console.ReadKey();
            
        }
    }
}
