using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numero;
            numero = 1;

            while (numero <= 100)
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero);
                    numero++;
                }
                else
                    numero++;
            }
            Console.ReadKey();
        }
    }
}
