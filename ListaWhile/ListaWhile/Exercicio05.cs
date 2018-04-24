using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listawhile1
{
    class Exercicio05
    {
         public Exercicio05()
        {
            Console.Write("Numero: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            Console.Write("Numero2: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("                        MENU  ");
            Console.WriteLine("   ---------------------------------------------");
            Console.WriteLine("   |   1                  | Somar              |");
            Console.WriteLine("   |   2                  | Subtrair           |");
            Console.WriteLine("   |   3                  | Multiplicar        |");
            Console.WriteLine("   |   4                  | Dividir            |");
            Console.WriteLine("   |   5                  | Sair               |");
            Console.WriteLine("   ---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            int opcao = Convert.ToInt32(Console.ReadLine());
            int quantidade = 0;


            while (opcao != 5)
            {
               


                if (opcao == 1)
                {
                    Console.WriteLine(numero + numero2);
                }
                else if (opcao == 2)
                {
                    Console.WriteLine(numero - numero2);
                }
                else if (opcao == 3)
                {
                    Console.WriteLine(numero * numero2);
                }
                else if (opcao == 4)
                {
                    Console.WriteLine(numero / numero2);
                }
                else if (opcao == 5)
                {
                    Console.Write("Saindo");
                }

                Console.WriteLine("                        MENU  ");
                Console.WriteLine("   ---------------------------------------------");
                Console.WriteLine("   |   1                  | Somar              |");
                Console.WriteLine("   |   2                  | Subtrair           |");
                Console.WriteLine("   |   3                  | Multiplicar        |");
                Console.WriteLine("   |   4                  | Dividir            |");
                Console.WriteLine("   |   5                  | Sair               |");
                Console.WriteLine("   ---------------------------------------------");

                Console.Write("Selecionar uma opção: ");
                opcao = Convert.ToInt32(Console.ReadLine());




                  

                


            }
        }
    }
}
