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
            int[] a = new int[9];
            int[] b = new int[9];
            int[] c = new int[9];
            int cont;

            Console.WriteLine("Vetor A.");
            for(cont = 0; cont <= 8; cont++)
            {
                Console.WriteLine("{0}º valor:", cont + 1);
                a[cont] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Veto B.");
            for(cont = 0; cont <= 8; cont++)
            {
                Console.WriteLine("{0}º valor:", cont + 1);
                b[cont] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Vetor A meno o B.");
            for (cont = 0; cont <= 8; cont++)
            {
                c[cont] = a[cont] - b[cont];
                Console.Write("{0}, ", c[cont]);
            }
            Console.ReadLine();
            


        }
    }
}
