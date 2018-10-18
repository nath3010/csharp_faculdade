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
            uint mes;
            double divida, aplicacao;
            divida = 10000;
            aplicacao = 1500;
            mes = 1;

            for(; ; )
            {
                divida = divida * 1.025;
                aplicacao = aplicacao * 1.04;
                if (aplicacao >= divida)
                    break;
                mes++;


            }
            Console.WriteLine(" Divida final: R${0:.00}\n Aplicação: R${1:.00}\n Meses necessários: {2}", divida, aplicacao, mes);
            Console.ReadKey();
        }

            
    }
}
