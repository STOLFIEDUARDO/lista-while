using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listawhile1
{
    class Exercicio01
    {
        public Exercicio01()
        {
            Console.Write("Escreva seu nome, para sair digite sair: ");
            string nome = Console.ReadLine();

            while (nome != "fim")
            {
                nome = Console.ReadLine();
            }
            


        }
    }
}
