using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double perimetro;
            double area;


            Console.WriteLine("Escreva o raio do círculo:");
            raio = double.Parse(Console.ReadLine());

            perimetro = (2 * 3.14) * raio;  //Não esquecer de por pnto de não virgula!!
            area = (raio * raio) * 3.14;

            Console.WriteLine(" O perímetro é: {0}", perimetro);
            Console.WriteLine("A área é: {0}", area);

            Console.ReadLine();
        }
    }
}
