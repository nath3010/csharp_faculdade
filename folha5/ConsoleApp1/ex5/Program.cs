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
          
            int c, nl, numero, s, a, q;

            c = nl = 0;
            numero = 0;

            Console.WriteLine(" Quantos números deseja ler?");
            nl = int.Parse(Console.ReadLine());

            for(c = 1;  c <= nl; c++)
            {
                Console.WriteLine(" Escreva um número:");
                numero = int.Parse(Console.ReadLine());
               Console.WriteLine(" Valor lido:{0}", numero);

                s = numero + 1;
                a = numero - 1;
                q = numero * numero;

                Console.WriteLine(" Antecessor: {0}\nSucessor: {1}\n Quadrado: {2}", a, s, q);


                
                

            }
            Console.ReadKey();

        }
    }
}
