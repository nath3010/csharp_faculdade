using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace folha3
{
    class Program
    {
        static void Main(string[] args)
        {
            int operador;
            double n1, n2, r;

            Console.WriteLine("Qual vai ser a operação?");
            operador = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o número um:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o número dois:");
            n2 = double.Parse(Console.ReadLine());

            switch (operador)
            {
                case 1:
                    r = (n1 + n2) / 2;
                    Console.WriteLine("A média entre os números digitados: {0:0.00}", r);
                    break;

                case 2:
                    if (n1 <= n2)
                    {
                        r = n2 - n1;
                        Console.WriteLine("A diferença do maior pelo menor é: {0:0.00}", r);
                    }
                    else
                    {
                        r = n1 - n2;
                        Console.WriteLine("A diferença do maior pelo menor é: {0:0.00}", r);
                    }
                    break;

                case 3:
                    r = n1 * n2;
                    Console.WriteLine("O produto entre os número digitados é: {0:0.00}", r);

                    break;

                case 4:
                    if (n2 != 0)
                    {
                        r = n1 / n2;
                        Console.WriteLine("A divisão do primeiro pelo segundo é: {0:0.00}", r);
                    }

                    else
                    {
                        Console.WriteLine("Não pode ser divisível por zero!! ");
                    }
                    break;
                default:
                    Console.WriteLine("Você não digitou uma operação!!");
                    break;
            }
            Console.ReadKey();


                    












                    
            
        }
    }
}
