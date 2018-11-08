using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[] b = new int[10];
            int cont;

            for(cont = 0; cont <= 9; cont++)
            {
                Console.WriteLine("{0}º valor:", cont + 1);
                a[cont] = int.Parse(Console.ReadLine());
            }
            for(cont = 9; cont >= 0; cont--)
            {
                b[cont] = a[cont];
                Console.Write("{0},", b[cont]);
            }
            Console.ReadKey();
        }
    }
}
