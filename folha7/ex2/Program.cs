using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetora = new int[8];
            int[] vetorb = new int[8];
            int cont;

            for(cont = 0; cont <= 7; cont++)
            {
                Console.WriteLine("{0}º valor:", cont + 1);
                vetora[cont] = int.Parse(Console.ReadLine());
                

            }
            for(cont = 0; cont <= 7; cont++)
            {
                vetorb[cont] = vetora[cont] * 3;
                Console.Write("{0}, ", vetorb[cont]);


            }

            
            Console.ReadKey();

        }
    }
}
