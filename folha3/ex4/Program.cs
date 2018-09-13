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
            int mes;
            Console.WriteLine("Qual é o mês de 2018?");
            mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1:
                    Console.WriteLine("Janeiro, 31 dias.");
                    break;
                case 2:
                    Console.WriteLine("Fevereiro, 28 dias ");
                    break;
                case 3:
                    Console.WriteLine("Março, 31 dias.");
                    break;
                case 4:
                    Console.WriteLine("Abril, 30 dias.");
                    break;
                case 5:
                    Console.WriteLine("Maio, 31 dias.");
                    break;
                case 6:
                    Console.WriteLine("Junho, 30 dias. ");
                    break;
                case 7:
                    Console.WriteLine("Julho, 31 dias.");
                    break;
                case 8:
                    Console.WriteLine("Agonsto, 31 dias.");
                    break;
                case 9:
                    Console.WriteLine("Setembro, 30 dias. ");
                    break;
                case 10:
                    Console.WriteLine("Outubro, 31 dias.");
                    break;
                case 11:
                    Console.WriteLine("Novembro, 30 dias.");
                    break;
                case 12:
                    Console.WriteLine("Dezembro, 31 dias.");
                    break;
                default:
                    Console.WriteLine("Você digitou o número do mês errado!!");
                    break;


            }
            Console.ReadKey();
        }
    }
}
