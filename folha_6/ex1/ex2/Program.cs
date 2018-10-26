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
            uint numero;
            numero = 99;

            while(numero >= 1)
            {
                if (numero % 2 != 0)
                {
                    Console.WriteLine(numero);
                    numero--;


                }
                else
                    numero--;
            }
            Console.ReadKey();
        }

    }
}
