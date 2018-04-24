using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listawhile1
{
    class Exercicio06
    {
        public Exercicio06()
        {
            Console.WriteLine("|Codigo |  TIPO      |  NOME                                  | VALOR |");
            Console.WriteLine("|----------------------------------------------------------------|");
            Console.WriteLine("| 1     |BOLOS      |Bolo brigadeiro                            |R$29,50|");
            Console.WriteLine("| 2     |BOLOS      |Bolo floresta negra                        |R$ 2,00|");
            Console.WriteLine("| 3     |BOLOS      |Bolo leite com nutella                     |R$29,23|");
            Console.WriteLine("| 4     |BOLOS      |Bolo Mousse de chocolate                   |R$ 7,10|");
            Console.WriteLine("| 5     |BOLOS      |Bolo Nega maluca                           |R$19,33|");
            Console.WriteLine("| 6     |Doces      |Bomba de creme                             |R$17,71|");
            Console.WriteLine("| 7     |Doces      |Bomba de morango                           |R$ 4,82|");
            Console.WriteLine("| 8     |Sanduíches |filé mignon com fritas e cheddar           |R$21,16|");
            Console.WriteLine("| 9     |Sanduíches |Hambúrguer com queijos, champgnon e rúcula |R$12,70|");
            Console.WriteLine("| 10    |Sanduíches |Provolone com salame                       |R$19,70|");
            Console.WriteLine("| 11    |Sanduíches |Vegetariano de berinjela                   |R$28,22|");
            Console.WriteLine("| 12    |Pizzas     |Calabresa                                  |R$ 8,98|");
            Console.WriteLine("| 13    |Pizass     |Napolitana                                 |R$ 0,42|");
            Console.WriteLine("| 14    |Pizass     |Peruana                                    |R$18,36|");
            Console.WriteLine("| 15    |Pizass     |Portuguesa                                 |R$27,50|");
            Console.WriteLine("| 16                | SAIR                                              |");
            Console.WriteLine("|-----------------------------------------------------------------------|");

            

            int codigo = 16;
            int quantidade = 1;
            while (quantidade <= codigo)
            {
                Console.Write("Olá, qual Seria seu pedido?: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                quantidade = codigo + 1;

            }


             


        }
    }
}
