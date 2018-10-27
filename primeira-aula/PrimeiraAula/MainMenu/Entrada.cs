using System;

namespace PrimeiraAula.MainMenu
{
    public static class Entrada
    {
        public static int ReadInt(string mensagem, int min, int max)
        {
            Saida.Display(mensagem);
            return ReadInt(min, max);
        }

        public static int ReadInt(int min, int max)
        {
            int valor = ReadInt();

            while (valor < min || valor > max)
            {
                Saida.Display("Por favor insira um inteiro entre {0} e {1} (incluso).", min, max);
                valor = ReadInt();
            }

            return valor;
        }

        public static int ReadInt()
        {
            string entrada = Console.ReadLine();
            int valor;

            while (!int.TryParse(entrada, out valor))
            {
                Saida.Display("Por favor insira um inteiro.");
                entrada = Console.ReadLine();
            }

            return valor;
        }

        public static int ReadInt(string mensagem)
        {
            Saida.Display(mensagem);
            return ReadInt();
        }

        public static float ReadFloat(string mensagem)
        {
            Saida.Display(mensagem);
            return ReadFloat();
        }
        public static float ReadFloat()
        {
            string entrada = Console.ReadLine();
            float valor;

            while (!float.TryParse(entrada, out valor))
            {
                Saida.Display("Por favor insira um valor flutuante.");
                entrada = Console.ReadLine();
            }

            return valor;
        }

        public static string ReadString(string mensagem)
        {
            Saida.Display(mensagem);
            return ReadString();
        }

        public static string ReadString()
        {
            return Console.ReadLine();
        }
    }
}
