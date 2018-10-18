using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numero, e, contador, numero2;
            e = 1;
            Console.WriteLine("Escreva um número");
            numero = uint.Parse(Console.ReadLine());
            numero2 = 1;
            for (contador = 1; contador < numero; contador++)
            {
                
                e += 1 / numero2;
                numero2++;
                Console.WriteLine(numero2);
            }
            Console.WriteLine(e);
            Console.ReadKey();
        }
    }
}
