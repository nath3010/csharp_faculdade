using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            float d, c, r;
            Console.WriteLine("Qual a cotação do dolar:");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine("Qual e o valor do dolar a se convertido a reais:");
            d = float.Parse(Console.ReadLine());
            r = c * d;

            Console.WriteLine("US${0:0.0} é R${1:0.0}", d, r);
            Console.ReadKey();

        }
    }
}
