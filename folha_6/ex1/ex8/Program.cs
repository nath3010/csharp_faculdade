using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero, soma;
            numero = 1;
            soma = 0;

            while(numero <= 20)
            {
                
                soma += (1 / numero);
                numero *= 2;

            }
            Console.WriteLine("Soma: {0}", soma);
            Console.ReadKey();
            
        }
    }
}
