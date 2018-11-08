using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int cont, quantidadep = 0, quantidadei = 0, pi;

            for (cont = 0; cont <= 9; cont++)
            {
                Console.WriteLine("Escreva o {0}º valor:", cont + 1);
                a[cont] = int.Parse(Console.ReadLine());

                
                if (a[cont] % 2 != 0)
                {
                    quantidadei += 1;
                }
            }
            pi = 10 * quantidadei ;

            Console.WriteLine("Quantidade de números ímpares:{0}", quantidadei);
            Console.WriteLine("Porcentagem de números ímpares:{0}%", pi);
            Console.ReadKey();
            
        }
    }
}
