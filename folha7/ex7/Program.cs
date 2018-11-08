using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[12];
            int[] z = new int[12];
            int cont;

            for(cont = 0; cont <= 11; cont++)
            {
                Console.WriteLine("Escreva o {0}º valor:", cont + 1);
                x[cont] = int.Parse(Console.ReadLine());
            }
            for(cont = 0; cont <= 11; cont++)
            {
                if(x[cont]%2 != 0)
                {
                    x[cont] *= 2;
                }
                else
                {
                    x[cont] = x[cont];
                }
            }
            for(cont = 0; cont <= 11; cont++)
            {
                z[cont] = x[cont];
                Console.WriteLine("{0},", z[cont]);
            }
            Console.ReadKey();

        }
    }
}
