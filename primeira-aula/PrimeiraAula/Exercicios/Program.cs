using System;
using PrimeiraAula.MainMenu;

namespace PrimeiraAula.Exercicios
{
    public class Ex3
    {
        public static void Inicio()
        { 
            int numero1, numero2, numero3, numero4, soma;

            Console.WriteLine("Digite o primeiro número");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("digite o segundo número");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um terceiro número");
            numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um quarto número.");
            numero4 = int.Parse(Console.ReadLine());

            soma = numero1 + numero2 + numero3 + numero4;

            Console.WriteLine("A soma dos número é: {0}", soma);

            Console.ReadLine(); //Para a pessoa clicar em uma tecla e fechar 
        }
    }
}
