using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace folha1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float n1, n2, n3, m;

            Console.WriteLine("Escreva o nome do aluno:");
            nome = Console.ReadLine();
            Console.WriteLine("Esceva a nota da primeira prova: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a nota da segunda prova:");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Escreva a nota da terceira prova:");
            n3 = float.Parse(Console.ReadLine());

            m = (n1 + n2 + n3) / 3;

            Console.WriteLine("A media do aluno {0} é {1:0.0}", nome, m);

            Console.ReadKey();
        }
    }
}
