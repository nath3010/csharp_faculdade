using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, r;
            Console.WriteLine("Qual é o salário:");
            salario = double.Parse(Console.ReadLine());

            if (salario < 500) {

                r = salario + (salario * 15 / 100);
                Console.WriteLine("O salário com reajuste é: R$ {0:0.00}", r);
            }

            else if (salario >= 500 || salario <= 1000)
            {
                r = salario + (salario * 10 / 100);
                Console.WriteLine("O salário com reajuste é: R$ {0:0.00}", r);
            }

            else if (salario > 1000)
            {
                r = salario + (salario * 5 / 100);
                Console.WriteLine("O salário com reajuste é: R$ {0:0.00}", r);
            }

           

            Console.ReadKey();
             

            
        }
    }
}
