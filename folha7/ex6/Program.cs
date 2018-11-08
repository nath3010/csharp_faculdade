using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[20];
            string nome;
            int cont;

            for(cont = 0; cont <= 19; cont++)
            {
                Console.WriteLine("Escreva o {0}º nome:", cont + 1);
                nomes[cont] = Console.ReadLine();
            }
            Console.WriteLine("Digite o nome:");
            nome = Console.ReadLine();
            
            
                if(nomes.Contains(nome))
                {
                    Console.WriteLine("Nome está no Cadastrado!");
                }
                else
                {
                    Console.WriteLine("Nome não está cadastrado!");
                }
            

            Console.ReadKey();

        }
    }
}
