﻿using System;
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

        public void Display(ConsoleColor cor)
        {
            for (int i = 0; i < Opcao.Count; i++)
            {
                Saida.Write(cor, $"{i + 1}. ");
                Console.WriteLine("{0}", Opcao[i].Nome);
            }
            int escolha = Entrada.ReadInt("Escolha uma opção:", min: 1, max: Opcao.Count);
            Console.Clear();
            Opcao[escolha - 1].Metodo();
        }

        public void Display(ConsoleColor cor, ConsoleColor cor2)
        {
            for (int i = 0; i < Opcao.Count; i++)
            {
                Saida.Write(cor, $"{i + 1}. ");
                Saida.Write(cor2, $"{Opcao[i].Nome}\n");
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
            return this; //Assim conseguimos adicionar varios .Add em cascata.
        }

        public static void Esperar()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
