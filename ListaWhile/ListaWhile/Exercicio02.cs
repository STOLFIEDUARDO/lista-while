using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listawhile1
{
    class Exercicio02
    {
        public Exercicio02()
        {
            Console.WriteLine("Digite sua idade, a partir do 128 ele para");
            int idade = Convert.ToInt32(Console.ReadLine());

            while (idade <= 128)
            {
                idade = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
