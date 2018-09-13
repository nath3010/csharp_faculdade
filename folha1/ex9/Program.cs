using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Valor de a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor de b:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("O valor de a é {0} e o de b é {1}.", b, a);
            Console.ReadKey();
        }
    }
}
