using System;

namespace PrimeiraAula.MainMenu
{
    public class Opcao
    {
        public string Nome { get; private set; }
        public Action Metodo { get; private set; }

        public Opcao(string nome, Action metodo)
        {
            Nome = nome;
            Metodo = metodo;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
