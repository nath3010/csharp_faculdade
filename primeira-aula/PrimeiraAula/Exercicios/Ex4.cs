using System;
using PrimeiraAula.MainMenu;

namespace PrimeiraAula.Exercicios
{
    public class Ex4
    {
        public static void Inicio()
        {
            float raio, perimetro, area;


            Console.WriteLine("Escreva o raio do círculo:");
            raio = float.Parse(Console.ReadLine());
            

            perimetro = Convert.ToUInt32((2 * 3.14) * raio);  //Não esquecer de por pnto de não virgula!!
            area = Convert.ToUInt32((raio * raio) * 3.14);

            Console.WriteLine(" O perímetro é: {0}", perimetro);
            Console.WriteLine("A área é: {0}", area);

            Console.ReadLine();
        }
    }
}
