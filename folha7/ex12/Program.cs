using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a = new int[10];
            int cont, soma = 0, qn = 0;

            for (cont = 0; cont <= 9; cont++)
            {
                Console.WriteLine("Escreve o {0}º valor:", cont + 1);
                a[cont] = int.Parse(Console.ReadLine());
                if(a[cont] >= 0)
                {
                    soma += a[cont];
                }
                else if ( a[cont] < 0)
                {
                    qn += 1;

                }
            }
            Console.WriteLine(" Soma números positivos: {0}\n Quantidade de números negativos:{1}", soma, qn);
            Console.ReadKey();

        }
    }
}
