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
            int n, n_impares,quadrado, c;
           
            n_impares = 1;
            quadrado = 1;
            Console.WriteLine("Ecreva o número:");
            n = int.Parse(Console.ReadLine());

            for (c = 2; c <= n; c++)
            {
                n_impares += 2;


                quadrado += n_impares;
                  
                




                
            }
            Console.WriteLine("O seu quadrado: {0}",quadrado);
            
            Console.ReadKey();
        }
    }
}
