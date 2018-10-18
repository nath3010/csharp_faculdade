using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero, f, d;
            int c;
            f = 1;
            d = 0;
            Console.WriteLine("Número:");
            numero = float.Parse(Console.ReadLine());

            for ( c = 1; c <= numero; c++)
            {
                
                if( numero % f == 0)
                {
                    
                 Console.WriteLine("{0} pode ser dividido por:{1}",numero, f);
                    d += 1;
                }
                f += 1;
               
            }
            Console.WriteLine("Numero de divisores:{0}", d);
           

            Console.ReadKey();
        }
    }
}
