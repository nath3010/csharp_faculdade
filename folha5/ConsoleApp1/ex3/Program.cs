using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero_desejado, numero, par, d, c, m;
            par = 0;
            d = 0;

            Console.WriteLine("Quantos números deseja inserir:");
            numero_desejado = float.Parse(Console.ReadLine());
            Console.WriteLine("                            ");

            for (c = 1; c <= numero_desejado; c++)
            {
                Console.WriteLine("Digite um número:");
                numero = float.Parse(Console.ReadLine());
                Console.WriteLine("                            ");

                if (numero % 2 == 0)
                {
                    par = par + numero;
                    d++;
                }
            }
            m = par / d;
            Console.WriteLine("Media:{}", m);


            Console.ReadKey();
        }
    }
}
