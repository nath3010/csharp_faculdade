using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, m;
            string c;
            Console.WriteLine("Nota laboratório:");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota avaliação semestral:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Nota exame final:");
            n3 = float.Parse(Console.ReadLine());


            if ((n1 >= 0 && n1 <= 10) && (n2 >= 0 && n2 <= 10) && (n3 >= 0 && n3 <= 10))
            {

                m = (n1 * 2 + n2 * 3 + n3 * 5) / (2 + 3 + 5);


                if (m >= 8.0 && m <= 10.0)
                {
                    c = "A";
                }

                else if (m >= 7 && m < 8)
                {
                    c = "B";
                }
                else if (m >= 6 && m < 7)
                {
                    c = "C";
                }
                else if (m >= 5 && m < 6)
                {
                    c = "D";
                }
                else
                {
                    c = "E";
                }
                Console.WriteLine("média: {0:0.00} - Conceito: {1}", m, c);
            }
            else
                Console.WriteLine("Os valors das notas tem que ser entre 0 e 10!!");

            Console.ReadKey();

             


        }
    }
}
