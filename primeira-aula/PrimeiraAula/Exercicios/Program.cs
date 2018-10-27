using System;
using PrimeiraAula.MainMenu;

namespace PrimeiraAula.Exercicios
{
    public class Ex3
    {
        public static void Inicio()
        { 
            int numero1 = Entrada.ReadInt("Digite o primeiro número:");
            int numero2 = Entrada.ReadInt("Digite o segundo número:");
            int numero3 = Entrada.ReadInt("Digite o terceiro número:");
            int numero4 = Entrada.ReadInt("Digite o quarto número:");
            int soma = numero1 + numero2 + numero3 + numero4;
            Console.WriteLine("A soma dos número é: {0}", soma);
            Menu.Esperar();
        }
    }
}
