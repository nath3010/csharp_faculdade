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
            int p;
            float vt, v;

            Console.WriteLine("Qual é o valor da compra?");
            v = float.Parse(Console.ReadLine());

            Console.WriteLine("Quantas pacelas o cliente vai pagar?");
            p = int.Parse(Console.ReadLine());

            vt = v / p;

            Console.WriteLine("O cliente vai pagar {0:0.0} em {1} parcelas de R${2:0.0}", v, p, vt);

            Console.ReadKey();
        }
    }
}
