using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PrimeiraAula.MainMenu;
using PrimeiraAula.Exercicios;

namespace PrimeiraAula
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu menu = new Menu()
                .Add("Ex1", () => Ex1.Inicio());
            menu.Display();

        }
    }
}
