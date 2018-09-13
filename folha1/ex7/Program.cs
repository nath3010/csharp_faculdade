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
            double km, l, m;

            Console.WriteLine("Qual foi a distância total em Km?");
            km = double.Parse(Console.ReadLine());
            Console.WriteLine("Quanto de combustível você usou para percorrer? ");
            l = double.Parse(Console.ReadLine());
            m = km / l;

            Console.WriteLine("O consumo médio foi de: {0:0.00}", m);
            Console.ReadKey();

        }
    }
}
