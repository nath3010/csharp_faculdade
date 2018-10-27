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
            uint numero;
            numero = 1000;
            while(numero <= 1999)
            {
                if (numero / 11 == 0 || numero % 11 == 5)
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
