using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cargo, idade;
            double sb, r, g, st;

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Cargo:");
            cargo = Console.ReadLine();
            Console.WriteLine("Idade:");
            idade = Console.ReadLine();

            Console.WriteLine("Salário bruto:");
            sb = double.Parse(Console.ReadLine());

            r = sb + ((sb * 38) / 100);
            g = r + ((r * 20) / 100);
            st = g - ((g * 15) / 100);

            Console.WriteLine("Nome: {0} \n Cargo: {1} \n Idade: {2} \n Salário bruto: R$ {3:0.00}  ", nome, cargo, idade, sb);
            Console.WriteLine("Salário líquido: R$ {0:0.00}", st);

            Console.ReadKey();
        }
    }
}
