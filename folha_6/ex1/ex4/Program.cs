using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numero, resultado;
            numero = 0;

            while(numero <= 10)
            {
                resultado = 9 * numero;
                Console.WriteLine("9 x {0} = {1}", numero, resultado);
                numero++;
            }
            Console.ReadKey();
        }
    }
}
