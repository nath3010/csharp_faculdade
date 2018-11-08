using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] a = new int[10];
            int cont, quantidadep = 0, quantidadei = 0;

            for(cont = 0; cont <= 9; cont++)
            {
                Console.WriteLine("Escreva o {0}º valor:", cont + 1);
                a[cont] = int.Parse(Console.ReadLine());

                if (a[cont] % 2 == 0)
                {
                    quantidadep += 1;
                }
                else if(a[cont] % 2 != 0)
                {
                    quantidadei += 1;
                }
            }
            Console.WriteLine(" Quantidade de números pares: {0}\n Quantidade de números ímpares: {1} ", quantidadep, quantidadei);
            Console.ReadKey();
        }
    }
}

