using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador, numero, div;
            string resultado;

            Console.WriteLine("Escreva um número:");
            numero = int.Parse(Console.ReadLine());
            resultado = "";

            div = 0;
            for (contador = 1; contador <= numero; contador++)
            {
                if (numero % contador == 0 ) 
                {
                    div++;

                    
                    
                    
                    
                }
               
                
                
            }

            if (div == 2)
            {
                Console.WriteLine("É primo!");
            }

            else
            {
                Console.WriteLine("Não é primo!");
            }
            Console.ReadKey();
        }

    }
}
