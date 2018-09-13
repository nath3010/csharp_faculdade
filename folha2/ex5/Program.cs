using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string op;
            double n1, n2, c;

            Console.WriteLine("Número um:");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Número dois:");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a operação?");
            op = Console.ReadLine();

            if (op == "+")
            {
                c = n1 + n2;
                Console.WriteLine("O resultado é: {0:0.00}", c);
            }
            else if (op == "-")
            {
                c = n1 - n2;
                Console.WriteLine("O resultado é:{0:0.00}", c);
            }
            else if (op == "*")
            {
                c = n1 * n2;
                Console.WriteLine("O resultado é:{0:0.00}", c);

            }
            else if (op == "/" && n2 != 0)
            {
                c = n1 / n2;
                Console.WriteLine("O resultado é:{0:0.00}", c);
            }
            else if (op == "/" && n2 == 0)
            {
                Console.WriteLine("Erro de divisão por 0!");
            }
            else
                Console.WriteLine("Não foi digitada uma operação!");

            Console.ReadKey();


                




            
               
                
                
               

        }
    }
}
