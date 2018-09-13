using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, area, tinta, mao, rolo, lata, custo, vr, vl;

            Console.WriteLine("Aresta a:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Aresta b:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Aresta c:");
            c = int.Parse(Console.ReadLine());

            area = 2 * a * b + 2 * b * c + 2 * a * c;
            tinta = area * 3;
            mao = 20 * area;
            rolo = (area / 10);
            if ((area % 10) != 0)
                rolo++;
            vr = rolo * 5;



            lata = (tinta / 5);
            if ((area % 5) != 0)
                lata++;
            vl = lata * 45;


            custo = mao + vr + vl;

            Console.WriteLine("Quantidade de tinta necessária por metro quadrado: {0:0.0} L", tinta);
            Console.WriteLine("Custo total: R$ {0:0.00}", custo);
            Console.ReadKey();
        }
    }
}
