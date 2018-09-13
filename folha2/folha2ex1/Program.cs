using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace folha2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, media;
            Console.WriteLine("Nota um:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota dois:");
            n2 = double.Parse(Console.ReadLine());
            media = (n1 + n2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!\n Media: {0:0.00}", media);

            }
            else
            {
                Console.WriteLine("Reprovado!\n Media: {0:0.00}", media);
            }
            Console.Read();
        }
    }
}
