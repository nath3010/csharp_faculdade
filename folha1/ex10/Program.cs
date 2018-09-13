using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            double ifv, ip, ifn, ano, anop, anofv, anofn;


            Console.WriteLine("Nome do pai:");
            nome = Console.ReadLine();
            Console.WriteLine("Idade do pai:");
            ip = double.Parse(Console.ReadLine());
            Console.WriteLine("Ano atual:");
            ano = double.Parse(Console.ReadLine());

            ifv = Math.Sqrt(ip); // raiz quadrada
            ifn = ifv - 1.5;
            anop = ano - ip;
            anofv = ano - ifv;
            anofn = ano - ifn;


            Console.WriteLine(" Ano de nascimento do {0} é {1}.", nome, anop);

            //Math.floor para arredondar para baixo

            Console.WriteLine("Idade é {0} e o ano é {1} do filho mais velho.", Math.Floor(ifv), Math.Floor(anofv));
            Console.WriteLine("Idade é {0} e o ano é {1} do filho mais novo.", Math.Floor(ifn), Math.Floor(anofn));

            Console.ReadKey();

        }
    }
}
