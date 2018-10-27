using System;
using PrimeiraAula.MainMenu;

namespace PrimeiraAula.Exercicios
{
    public class Ex4
    {
        public static void Inicio()
        {
            float raio = Entrada.ReadFloat("Escreva o raio do círculo:");
            float perimetro = (float)(2 * 3.14) * raio;  //Não esquecer de por pnto de não virgula!!
            float area = (float)((raio * raio) * 3.14);
            Console.WriteLine(" O perímetro é: {0}", perimetro);
            Console.WriteLine("A área é: {0}", area);
            Menu.Esperar();
        }
    }
}
