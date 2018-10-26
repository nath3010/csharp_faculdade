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
            float numero=1, maior = 0, menor = 0, media = 0, soma = 0, qn = 0;
            int qp = 0;

            while (true)
            {
                Console.WriteLine("Escreva um número:");
                numero = float.Parse(Console.ReadLine());
                
                if (numero != 0)
                {
                    soma += numero;
                    qn++;
                    if (qn == 1)
                    {

                        maior = numero;
                        menor = numero;
                    }
                    else if (numero > maior)
                        maior = numero;
                    else if (numero < menor)
                        menor = numero;

                    if (numero % 2 == 0)
                    {
                        qp++;

                    }
                }
                else
                {
                    if (numero == 0)
                        break;
                }
            }
            media = soma / qn;
            Console.WriteLine(" Quatidade de números digitados: {0}\n Quantidade de números pares: {1}", qn, qp);
            Console.WriteLine(" Maior valor: {0}\n Menor valor: {1}",maior, menor);
            Console.WriteLine(" Soma: {0}\n Media: {1}", soma, media);
            Console.ReadKey();

            
            
            
        }
    }
}
