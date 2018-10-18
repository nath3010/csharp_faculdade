using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float c, m, d, par;
            d = 0;
            par = 0;


            for (c = 13; c <= 73; c++)
            {
                if (c % 2 == 0)
                {
                    d++;
                    par = par + c;


                }



            }


            m = par / d;
            Console.WriteLine(m);

            Console.ReadKey();
        }
    }
}
