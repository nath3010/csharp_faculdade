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
            string nome;
            double nh, nd, ir, inss, sl, sb;

            Console.WriteLine("nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Número de horas trabalhadas:");
            nh = double.Parse(Console.ReadLine());
            Console.WriteLine("Número de dependentes:");
            nd = double.Parse(Console.ReadLine());

            sb = (nh * 12) + (nd * 40);
            ir = sb * 5 / 100;
            inss = sb * 8.5 / 100;
            sl = (sb - ir) - inss;

            Console.WriteLine("Nome: {0} \n Salário bruto: R$ {1:0.00} \n Desconto do IR R$ {2:0.00}", nome, sb, ir);
            Console.WriteLine("Desconto INSS: R$ {0:0.00} \n Salário líquido: R$ {1:0.00}", inss, sl);

            Console.ReadKey();
        }
    }
}
