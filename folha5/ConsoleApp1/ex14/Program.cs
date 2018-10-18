using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxa_dada, total, s, qs;
            s = 5;
            qs = 0;

            Console.WriteLine("Qual é a taxa:");
            taxa_dada = int.Parse(Console.ReadLine());
            if (taxa_dada >= 8)
            {
                for (; ; )
                {
                    if (taxa_dada >= s)
                    {
                        taxa_dada -= s;
                        qs++;

                    }
                    else
                    {
                        if (qs > 0)
                        {
                            Console.WriteLine("Total de {0}  selos: {1}", qs, s);
                        }
                        if (s == 5)
                        {
                            s = 3;
                            qs = 0;
                        }
                        if (taxa_dada == 0)
                        {
                            break;
                        }
                    }
                }
            }

            else
            {
                Console.WriteLine("Taxa minima de 8 centavo!");
                
            }
                   


            
            Console.ReadKey();

        }
    }
}
