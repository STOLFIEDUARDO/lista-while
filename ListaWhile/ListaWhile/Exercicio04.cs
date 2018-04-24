using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listawhile1
{
    class Exercicio04
    {
        public Exercicio04()
        {


            Console.Write("Quantidade de carros para cadastrar: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int quantidade = 0;
            int soma = 0, valordocarro = 0, anodocarro = 0, mediaanodocarro = 0, letrag = 0, letraa = 0;

            while (quantidade < numero)
            {
                quantidade = quantidade + 1;
                Console.Write("Modelo: ");
                string modelo = Console.ReadLine();
             
              //  Console.Write("Valor: ");
               // double valor = Convert.ToDouble(Console.ReadLine());

              
                Console.Write("Ano do carro: ");
                anodocarro = Convert.ToInt32(Console.ReadLine());
                mediaanodocarro = ( mediaanodocarro + anodocarro);



                 

              
            }

            Console.Write(mediaanodocarro);








        }
    }
}
