using System;
using PrimeiraAula.MainMenu;

namespace PrimeiraAula.Exercicios
{
    public class Ex2
    {
        public static void Inicio()
        {
            float numero1 = Entrada.ReadFloat("Qual é o valor da base do retângulo?");
            float numero2 = Entrada.ReadFloat("Qual é o valor da altura do retângulo?");
            float area = numero1 * numero2;
            Console.WriteLine("Área = {0}", area);
            Menu.Esperar();
        }
    }
}
