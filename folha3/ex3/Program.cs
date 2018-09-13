using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, imc;

            Console.WriteLine("Qual é sua altura?");
            altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é seu peso?");
            peso = double.Parse(Console.ReadLine());
            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso!");
            }
            else if (imc >= 18.5 && imc <= 25)
            {
                Console.WriteLine("Peso normal.");
            }
            else if (imc > 25 && imc >= 30)
            {
                Console.WriteLine("Acima de peso");

            }

            else if (imc > 30)
            {
                Console.WriteLine("Bem acima do peso!!");
            }
            else
            {
                Console.WriteLine("Você não digitou certo!");
            }
            Console.ReadKey();






            
        }
    }
}
