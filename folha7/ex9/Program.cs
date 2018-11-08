using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];
            int[] b = new int[5];
            int cont, x;
          
            
            for(cont = 0; cont <= 4; cont++)
            {
                Console.WriteLine("Escreva o {0}º valor:", cont + 1);
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    a[cont] = x;
                }
                else
                {
                    b[cont] = x;
                }
            }
           
               

                
                
            
            for(cont = 0; cont <= 4; cont++)
            {
                
               Console.WriteLine(" Vetor A: ({0}) Vetor B: ({1})", a[cont], b[cont] );
            }

            Console.ReadKey();
        }
    }
}

