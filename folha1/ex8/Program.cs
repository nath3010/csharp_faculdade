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

            double salario, h, di, sl;
            string nome;

            Console.WriteLine("O nome do funcionário:");
            nome = Console.ReadLine();
            Console.WriteLine("Salário por hora:");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Número de horas trabalhadas:");
            h = double.Parse(Console.ReadLine());

            di = (h * salario) * 9.5 / 100;
            sl = (h * salario) - di;

            Console.WriteLine("O salário líquido do {0} é R${1:0.00}.", nome, sl);

            Console.ReadKey();

        }
    }
}
