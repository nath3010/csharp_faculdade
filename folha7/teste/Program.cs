using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            int[] B = new int[5];
            int c, x;
            for (c = 0; c <= 4; c++)
            {
                Console.WriteLine("Digite o {0}º número.", c + 1);
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    A[c] = x;
                }
                else
                {
                    B[c] = x;
                }
            }
            for (c = 0; c <= 4; c++)
            {
                Console.WriteLine("Vetor A nº{0}: ({1}) Vetor B nº{0}: ({2})", c + 1, A[c], B[c]);
            }
            Console.Read();
        }
    }
    
}
