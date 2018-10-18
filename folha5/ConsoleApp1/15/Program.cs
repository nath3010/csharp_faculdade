using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            int termos, contador, t1, t2, t3;
            t1 = 0;
            t2 = 1;
            t3 = 0;

            Console.WriteLine("Quantos termos deseja mostrar:");
            termos = int.Parse(Console.ReadLine());

            for(contador = 0; contador <=termos; contador++)
            {
                t3 = t1 + t2;
                t1 = t2;
                t2 = t3;

                Console.Write("{0},", t3);
            }
            Console.ReadKey();
        }
    }
}
