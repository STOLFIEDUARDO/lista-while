using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listawhile1
{
    class Exercicio03
    {
        public Exercicio03()
        {
            
            double  peso = 1;
            int quantidade = 0;

            while ((peso > 0) && (peso < 300))
            {
                Console.Write("Peso: ");
                peso = Convert.ToDouble(Console.ReadLine());
                quantidade = quantidade + 1;
                Console.WriteLine("Quantidade de pessoas cadastradas: " + quantidade );
            }


            
        }
    }
}
