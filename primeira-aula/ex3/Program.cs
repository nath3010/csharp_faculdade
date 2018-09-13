using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, soma;

            Console.WriteLine("Digite o primeiro número");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo número");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um terceiro número");
            n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um quarto número.");
            n4 = int.Parse(Console.ReadLine());

            soma = n1 + n2 + n3 + n4;

            Console.WriteLine("A soma dos número é: {0}", soma);

            Console.ReadLine(); //Para a pessoa clicar em uma tecla e fechar 
        }
    }
}
