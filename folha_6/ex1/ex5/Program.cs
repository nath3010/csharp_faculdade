using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome,op = "sim";
            float peso, altura, imc;
            
            

            while(op == "sim")
            {
                Console.WriteLine("Nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Peso:");
                peso = float.Parse(Console.ReadLine());
                Console.WriteLine("Altura:");
                altura = float.Parse(Console.ReadLine());

                imc = peso / (altura * altura);
                Console.WriteLine("IMC: {0:0.00}", imc);

                if (imc < 20)
                    Console.WriteLine("Abaixo do peso");
                else if (imc >= 20 && imc < 25)
                    Console.WriteLine("Normal");
                else if (imc >= 25 && imc < 30)
                    Console.WriteLine("Excesso de peso");
                else if (imc >= 30 && imc < 35)
                    Console.WriteLine("Obesidade");
                else if (imc > 35)
                    Console.WriteLine("Obesidade mórbida");

                Console.WriteLine("Deseja continuar?[sim/não]");
                op = Console.ReadLine();

                if (op != "sim")
                    Console.WriteLine("Até a próxima");


              


            }
            Console.ReadKey();
        }

    }
}
