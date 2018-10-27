using System;
using PrimeiraAula.MainMenu;

namespace PrimeiraAula.Exercicios
{
    public class Ex1
    {
        public static void Inicio()
        {
            string nome = Entrada.ReadString("Escreva o nome:");
            string telefone = Entrada.ReadString("Escreva o telefone:");
            string endereco = Entrada.ReadString("Escreva o endereço:");
            string cpf = Entrada.ReadString("Escreva o CPF:");
            Console.WriteLine("O nome é: {0}", nome);
            Console.WriteLine("O telefone é: {0}", telefone);
            Console.WriteLine("O endereço é: {0}", endereco);
            Console.WriteLine("O CPF é: {0}", cpf);
            Menu.Esperar();
        }
    }
}
