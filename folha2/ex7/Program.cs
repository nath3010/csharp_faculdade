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
            string cor;
            int dias;
            double p;
            Console.WriteLine("Quantos dias foi a locação?");
            dias = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é a cor do selo?");
            cor = Console.ReadLine();

            if (cor == "verde")
            {
                p = dias * 5.50;
                Console.WriteLine("Preço: R$ {0:0.00}", p);
            }

            else if (cor == "azul")
            {
                p = dias * 5.70;
                Console.WriteLine("Preço: R$ {0:0.00}", p);
            }
            else if (cor == "branco")
            {
                p = dias * 4;
                Console.WriteLine("Preço: R$ {0:0.00}", p);

            }
            else if (cor == "rosa")
            {
                p = dias * 3.50;
                Console.WriteLine("Preço: R$ {0:0.00}", p);
            }

            Console.ReadKey();
        }

    }
}
