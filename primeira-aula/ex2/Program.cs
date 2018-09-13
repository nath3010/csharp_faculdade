using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, area;
            Console.WriteLine("Qual e o valor da base do retângulo?");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual e o valor da altura do retângulo?");
            n2 = int.Parse(Console.ReadLine()); //Número usa parse.

            area = n1 * n2;

            Console.WriteLine("Área = {0}", area);

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey(); //Para clicar em uma tecla e sair
        }
    }
}
