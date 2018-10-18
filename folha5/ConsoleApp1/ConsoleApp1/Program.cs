using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, c;

            Console.WriteLine("Digite o número para tabuada:");
            n = int.Parse(Console.ReadLine());

            for (c = 0; c <= 10; c++)
            {
                r = c * n;
                Console.WriteLine("{0}x{1}={2}", n, c, r);

            }
            Console.ReadKey();
        }
    }
}
