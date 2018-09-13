using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anobissexto
{
    class Program
    {
        static void Main(string[] args)
        {
            double ano;
            Console.WriteLine("Qual é o ano:");
            ano = double.Parse(Console.ReadLine());

            if (ano % 4 == 0 && ano % 100 != 0)
                Console.WriteLine("O ano é Bissexto!");
            else if (ano % 100 == 0 && ano % 400 == 0)
                Console.WriteLine("O ano é Bissexto!");
            else
                Console.WriteLine("Não é bissexto!");
                    
                    Console.ReadKey();
        }
    }
}
