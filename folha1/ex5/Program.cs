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
            float v, i, it, d, dt;

            Console.WriteLine("Qual é o valor do carro?");
            v = float.Parse(Console.ReadLine());
            i = v * 45 / 100;
            it = v + i;
            d = it * 15 / 100;
            dt = it + d;

            Console.WriteLine("O valor do carro com o imposta e a porcentagem do distribuidor é de R${0:0.00}", dt);

            Console.ReadKey();
        }
    }
}
