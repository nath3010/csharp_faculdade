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
            int n, n2, c;
            n = n2= c = 0;
            Console.WriteLine("Ecreva o número:");
            n = int.Parse(Console.ReadLine());

            for(c = 1; c <=n; c++)
            {
                
                if (n2 % 2 != 0)
                {
                    Console.WriteLine(n2);
                    
                }
                else
                {
                    c--;
                   
                }

                n2++;
            }
            Console.ReadKey();


             

        }
    }
}
