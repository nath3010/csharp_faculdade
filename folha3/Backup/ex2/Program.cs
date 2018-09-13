using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo;
            double a,s,r;

            Console.WriteLine("Escrva o código:");
            codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Salário atual:");
            s = double.Parse(Console.ReadLine());


            switch (codigo)
            {
                case 1:
                    a = (s * 50) / 100;
                    r = s + a;
                    Console.WriteLine(" Cargo: Escriturária\n Aumento: R${0:0.00}\n Saláro com o aumento: R${1:0.00}", a, r);
                    break;
                case 2:
                    a = (s * 35) / 100;
                    r = s + a;
                    Console.WriteLine(" Cargo: Secretária\n Aumento: R${0:0.00}\n Salário com o aumento: R${1:0.00}", a, r);
                    break;
                case 3:
                    a = (s * 20) / 100;
                    r = s + a;
                    Console.WriteLine(" Cargo: Caixa\n Aumento R${0:0.00}\n Salário com o aumento: R${1:0.00}", a, r);
                    break;
                case 4:
                    a = (s * 10) / 100;
                    r = s + a;
                    Console.WriteLine(" Cargo: Gerente\n Aumento R${0:0.00}\n Salário com o aumento: R${1:0.00}", a, r);
                    break;
                case 5:
                    Console.WriteLine(" Cargo: Diretor\n Aumento Não tem aumento!\n Salário normal: R${0:0.00}", s);
                    break;
                default:
                    Console.WriteLine("Você não digitou o código certo!");
                    break;
            }
            Console.ReadKey();


            

        }
    }
}
