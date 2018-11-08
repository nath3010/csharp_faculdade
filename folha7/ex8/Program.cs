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
            int[] w = new int[9];
            int[] y = new int[9];
            int cont;
            
            for(cont = 0; cont <= 8; cont++)
            {
                Console.WriteLine("Escreva o {0}º valor:", cont + 1);
                w[cont] = int.Parse(Console.ReadLine());
            }
            for(cont = 0; cont <= 8; cont++)
            {
                if(cont % 2 == 0)
                {
                    w[cont] /= 2;

                }
                else
                {
                    w[cont] *= 5;
                }
            }
            for(cont = 0; cont <= 8; cont++)
            {
                y[cont] = w[cont];
                Console.Write("{0},", y[cont]);
            }
            Console.ReadKey();
        }
    }
}
