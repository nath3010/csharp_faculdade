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
            string c, nome;
            double s, sn;
            Console.WriteLine("Nome do funcionário:");
            nome = Console.ReadLine();
            Console.WriteLine("Qual é o salário:");
            s = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a categoria:");
            c = Console.ReadLine();

            switch (c)
            {
                case "a":
                case "c":
                case "f":
                case "h":
                    sn = s * 1.10;
                    Console.WriteLine(" Nome: {0}\n Categoria: {1}\n Novo salário: R$ {2:0.00}", nome, c, sn);
                    break;

                case "b":
                case "d":
                case "e":
                case "i":
                case "j":
                case "t":
                    sn = s * 1.15;
                    Console.WriteLine(" Nome: {0}\n Categoria: {1}\n Novo salário: R$ {2:0.00}", nome, c, sn);
                    break;

                case "k":
                case "r":
                    sn = s * 1.25;
                    Console.WriteLine(" Nome: {0}\n Categoria: {1}\n Novo salário: R$ {2:0.00}", nome, c, sn);
                    break;

                case "l":
                case "m":
                case "n":
                case "o":
                case "p":
                case "q":
                case "s":
                    sn = s * 1.35;
                    Console.WriteLine(" Nome: {0}\n Categoria: {1}\n Novo salário: R$ {2:0.00}", nome, c, sn);
                    break;

                case "u":
                case "v":
                case "x":
                case "y":
                case "w":
                case "z":
                    sn = s * 1.50;
                    Console.WriteLine(" Nome: {0}\n Categoria: {1}\n Novo salário: R$ {2:0.00}", nome, c, sn);
                    break;

                default:
                    Console.WriteLine("Não está na categoria!");
                    break;

                   
            }
            



            Console.ReadKey();
                
                


               
            

        }
    }
}
