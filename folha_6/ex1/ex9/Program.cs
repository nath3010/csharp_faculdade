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
            float numero, numero2, soma;
            numero2 = 1;
            numero = 1000;
            soma = 0;
            while(numero2 <= 50)
            {
                
                soma += numero / numero2;
                numero -= 3;
                numero2 += 1;


            }
            Console.WriteLine("Soma: {0}", soma);
            Console.ReadKey();
        }
    }
}
