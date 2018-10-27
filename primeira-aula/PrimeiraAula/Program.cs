using PrimeiraAula.MainMenu;
using PrimeiraAula.Exercicios;

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
                    .Add("Ex1", () => Ex1.Inicio())

                    .Add("Fechar", () => continuar = false);
                menu.Display();
            } while (continuar);

        }
    }
}
