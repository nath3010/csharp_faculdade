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
            int resultado, numero, cont;

            Console.WriteLine("Número para calcular o fatorial:");
            numero = int.Parse(Console.ReadLine());
            cont= numero;
            resultado = numero;

            while (cont > 1)
            {
                cont--;
                resultado = resultado * cont;

            }
            Console.WriteLine("{0}! = {1}", numero, resultado);
            Console.ReadKey();
        }
    }
}
