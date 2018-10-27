using System;

namespace PrimeiraAula.MainMenu
{
    public static class Saida
    {
        public static void WriteLine(ConsoleColor cor, string mensagem, params object[] argumentos)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem, argumentos);
            Console.ResetColor();
        }

        public static void WriteLine(ConsoleColor cor, string mensagem)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine(mensagem);
            Console.ResetColor();
        }

        public static void WriteLine(string mensagem, params object[] argumentos)
        {
            Console.WriteLine(mensagem, argumentos);
        }

        public static void Display(string mensagem, params object[] argumentos)
        {
            mensagem = mensagem.Trim() + " ";
            Console.Write(mensagem, argumentos);
        }

        public static void Write(ConsoleColor cor, string mensagem)
        {
            Console.ForegroundColor = cor;
            Console.Write(mensagem);
            Console.ResetColor();
        }
    }
}
