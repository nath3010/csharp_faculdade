using System;
using System.Collections.Generic;

namespace PrimeiraAula.MainMenu
{
    public class Menu
    {
        private IList<Opcao> Opcao { get; set; }

        public Menu()
        {
            Opcao = new List<Opcao>();
        }

        public void Display()
        {
            for (int i = 0; i < Opcao.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, Opcao[i].Nome);
            }
            int escolha = Entrada.ReadInt("Escolha a opção:", min: 1, max: Opcao.Count);
            Console.Clear();
            Opcao[escolha - 1].Metodo();
        }

        public Menu Add(string option, Action callback)
        {
            return Add(new Opcao(option, callback));
        }

        public Menu Add(Opcao option)
        {
            Opcao.Add(option);
            return this;
        }

        public static void Esperar()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
