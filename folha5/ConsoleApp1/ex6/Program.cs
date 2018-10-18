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
            int numero;
            

            Console.WriteLine("Número:");
            numero = int.Parse(Console.ReadLine());
            int f = numero;
            for ( int c = (numero-1) ; c >= 1; c--)
            {
                f *= c;
            }

            Console.WriteLine("{0}! = {1}", numero, f);
            Console.ReadKey();
        }


    }
}
