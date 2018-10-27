using System;
using PrimeiraAula.MainMenu;

namespace primeira_aula
{
    class Ex1
    {
        static void Main(string[] args)
        {
            string nome, endereço, cpf, telefone;
            
            Console.WriteLine("Escreva o nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Escreva o telefone:");
            telefone = Console.ReadLine();

            Console.WriteLine("Escreva o endereço:");
            endereço = Console.ReadLine();

            Console.WriteLine("Escreva o CPF:");
            cpf = Console.ReadLine();

            Console.WriteLine("O nome é: {0}", nome);
            Console.WriteLine("O telefone é: {0}", telefone);
            Console.WriteLine("O endereço é: {0}", endereço);
            Console.WriteLine("O CPF é: {0}", cpf);

            Console.ReadLine();
        }
    }
}
