using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, r, h;

            Console.WriteLine("Digite o raio:");
            r = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura:");
            h = float.Parse(Console.ReadLine());

            v = 3.14 * h * (r * r);

            Console.WriteLine("O volume é: {0:0.00}", v);

            Console.ReadKey();
        }
    }
}
