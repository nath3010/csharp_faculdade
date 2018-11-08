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
            string[] a = new string[8];
            string[] b = new string[5];
            string[] c = new string[13];
            int cont;

            Console.WriteLine("Vetor A.");
            for(cont = 0; cont <=7; cont++)
            {
                Console.WriteLine("{0}º Palavra:", cont + 1);
                a[cont] = Console.ReadLine();
            }
            Console.WriteLine("Vetor B");
            for(cont = 0; cont <= 4; cont++)
            {
                Console.WriteLine("{0}º Palavra:", cont + 1);
                b[cont] = Console.ReadLine();
            }
            for(cont = 0; cont <= 7; cont++)
            {
                c[cont] = a[cont];

                
            }
            for(cont = 0; cont<= 4; cont++)
            {
                c[cont] = b[cont];

            }
            for(cont = 0; cont <= 12; cont++)
            {
                Console.WriteLine("{0},", c[cont]);
            }
            Console.ReadKey();

        }
    }
}
