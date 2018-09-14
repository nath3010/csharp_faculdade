using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2comif
{
    class Program
    {
        static void Main(string[] args)
        {

           
            string c, nome;
            double s, sn = 0;


            Console.WriteLine("Escreva o nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Escreva o salário:");
            s = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a categoria:");
            c = Console.ReadLine();

            if (c == "a" || c == "c" || c == "f" || c == "h")
            {
                sn = s * 1.10;
               
            }
            else if (c == "b" || c == "d" || c == "e" || c == "i" || c == "j" || c == "t")
            {
                sn = s * 1.15;
                
            }
            else if (c == "k" || c == "r")
            {
                sn = s * 1.25;
               
            }
            else if (c == "l" || c == "m" || c == "n" || c == "o" || c == "p" || c == "q" || c == "s")
            {
                sn = s * 1.35;
                
            }
            else if (c == "u" || c == "v" || c == "x" || c == "y" || c == "w" || c == "z")
            {
                sn = s * 1.50;
               
            }
            else
            {

                Console.WriteLine("Categoria inválida!");
                Console.ReadKey();

                return;
                
            }

            Console.WriteLine(" Nome: {0}\n Categoria: {1}\n Novo salário: R$ {2:0.00}", nome, c, sn);


            Console.ReadKey();




        }
    }
}
