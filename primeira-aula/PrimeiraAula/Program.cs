using PrimeiraAula.MainMenu;
using System;

namespace PrimeiraAula
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            do
            {
                Menu menu = new Menu()
                    .Add("Ex1", () => Exercicios.Ex1.Inicio())
                    .Add("Ex2", () => Exercicios.Ex2.Inicio())
                    .Add("Ex3", () => Exercicios.Ex3.Inicio())
                    .Add("Ex4", () => Exercicios.Ex4.Inicio())
                    .Add("Fechar", () => continuar = false);
                menu.Display(ConsoleColor.Cyan, ConsoleColor.Green);
            } while (continuar);
        }
    }
}
