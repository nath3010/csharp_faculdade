using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float c, f;

            Console.WriteLine("Escreva a temperatura em Celsius: ");
            c = float.Parse(Console.ReadLine());
            f = (9 * c + 160) / 5;

            Console.WriteLine("{0} em °C é {1:0.0} em °F. ", c, f);
            Console.ReadKey();
        }
    }
}
