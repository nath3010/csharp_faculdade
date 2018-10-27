using System;

namespace PrimeiraAula.Exercicios
{
    public class Ex2
    {
        public static void Inicio()
        {
            int n1, n2, area;
            Console.WriteLine("Qual e o valor da base do retângulo?");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual e o valor da altura do retângulo?");
            n2 = int.Parse(Console.ReadLine()); //Número usa parse.

            area = n1 * n2;

            Console.WriteLine("Área = {0}", area);

            Console.WriteLine("Aperte uma tecla para sair.");
            Console.ReadKey(); //Para clicar em uma tecla e sair
        }
    }
}
