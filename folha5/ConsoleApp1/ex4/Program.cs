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
            int maior, menor, c, t,numero;
            maior = 0;
            menor = 0;
            t = 0;

            for (c = 1; c <= 50; c++)
            {
                Console.WriteLine("Escreva um número:");
                numero = int.Parse(Console.ReadLine());
                t += 1;
                if (t == 1)
                {
                    maior = menor = numero;
                }
                else
                {
                    if (numero > maior)
                    {

                        maior = numero;
                    }

                    if (numero < menor)
                    {
                        menor = numero;

                    }

                }



              
            }
           
            Console.WriteLine(" Maior:{0}\n Menor:{1}", maior, menor);

            Console.ReadKey();
        }
    }
}
