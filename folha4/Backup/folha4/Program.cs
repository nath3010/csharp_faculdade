using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace folha4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maior, meio, menor;

            Console.WriteLine("Digite o valor um:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor dois:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor três:");
            c = int.Parse(Console.ReadLine());
            //para ver o maior valor
            maior = a;
            if (b > a && b > c) {
                maior = b;
            }
            else if (c > a && c > b){
                maior = c;
            }
            // Para ver o menor valor
            menor = a;
            if (b < a && b < c) {
                menor = b;
            }
            else if (c < a && c < b) {
                menor = c;
            }
            // Para ver o valor do meio
            meio = (a + b + c) - (maior + menor);
           
            Console.WriteLine("{0}, {1}, {2}", menor, meio, maior);
           
            Console.ReadKey();



            





        }
    }
}
