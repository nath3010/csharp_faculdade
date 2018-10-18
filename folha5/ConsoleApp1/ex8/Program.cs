using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, div, c;

            Console.WriteLine("Início:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Fim:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Divisor:");
            div = int.Parse(Console.ReadLine());

            for ( c = n1; c <= n2; c++ )
            {
                if(n1 % div == 0)
                {
                    Console.WriteLine("número divisiveis por {0}: {1}", div, n1);

                }

                n1++;
            }
            Console.ReadKey();
        }
    }
}
