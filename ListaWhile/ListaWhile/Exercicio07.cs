using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listawhile1
{
    class Exercicio07
    {
        public Exercicio07()
        {

            int atual = 0;

           

            while (atual < 22)
            {
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Idade: ");
                int idade = Convert.ToInt32(Console.ReadLine())


                Console.Write("Peso: ");
                double peso = Convert.ToDouble(Console.ReadLine());

                Console.Write("Sexo: ");
                string sexo = Console.ReadLine();

                Console.Write("Altura: ");
                double altura = Convert.ToDouble(Console.ReadLine());

                Console.Write("Gols marcados: ");
                int gols = Convert.ToInt32(Console.ReadLine());

                Console.Write("Cartões Amarelos: ");
                int cartao = Convert.ToInt32(Console.ReadLine());

                Console.Write("Cartões Vermelhos: ");
                int cartaov = Convert.ToInt32(Console.ReadLine());



                Console.Clear();

                atual = atual + 1;


                



            }





        









 
        }
    }
}
