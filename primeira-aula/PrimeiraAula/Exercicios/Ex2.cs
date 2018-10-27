using System;
using PrimeiraAula.MainMenu;

namespace PrimeiraAula.Exercicios
{
    public class Ex2
    {
        public static void Inicio()
        {
            int numero1 = Entrada.ReadInt("Qual é o valor da base do retângulo?");
            int numero2 = Entrada.ReadInt("Qual é o valor da altura do retângulo?");

            int area = numero1 * numero2;

            Console.WriteLine("Área = {0}", area);

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey(); //Para clicar em uma tecla e sair
        }
    }
}
