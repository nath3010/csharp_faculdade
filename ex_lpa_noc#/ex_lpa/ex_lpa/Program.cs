using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_lpa
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Escreva lado a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva lado b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Escreva lado c;");
            c = double.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < b + a)
            {
                if (a == b && b == c)
                {
                    Console.WriteLine("Equilatero");
                }
                else if (a == b  && b != c || a == c && a != b || b == c && b != a )
                {
                    Console.WriteLine("Isósceles");


                }
                else
                {
                    Console.WriteLine("Escaleno");
                }
                
            }
            else
            {
                Console.WriteLine("Não é um triangulo");
            }

            Console.ReadKey();
        }
    }
}
