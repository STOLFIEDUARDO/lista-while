using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listawhile1
{
    class Whilee
    {
        static void Maiwwn(string[] args)
        {
            int soma = 0, maiornumero = int.MinValue, menornumero = int.MaxValue;
            Console.WriteLine();
            string historico = "";

            Console.WriteLine("Dogite um número, caso queira sair digite 8001");
            int numero = Convert.ToInt32(Console.ReadLine());
            int quantidade = 0, quantidadepositivo = 0, quantidadenegativo = 0, quantidadeneutro = 0;
            while (numero != 8001)
            {
                soma = soma + numero;
                quantidade = quantidade + 1;
                historico = historico + numero + ", ";

                if (numero > maiornumero)
                {
                    maiornumero = numero;
                }
                if (numero < menornumero)
                {
                    menornumero = numero;
                }
                if (numero > 0)
                {
                    quantidadepositivo = quantidadepositivo + 1;
                }
                else if (numero != 0)
                {
                    quantidadenegativo = quantidadenegativo + 1;
                }
                else
                {
                    quantidadeneutro = quantidadeneutro + 1;
                }
                Console.WriteLine("Digite um númmero, para sair digite 8001");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            double media = soma / quantidade;
            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Média: " + media);
            Console.WriteLine("Menor número: " + menornumero);
            Console.WriteLine("Quantidade Positivos: " + quantidadepositivo);
            Console.WriteLine("Quantidade Negativos: " + quantidadenegativo);
            Console.WriteLine("Quantidade Neutros: " + quantidadeneutro);
            Console.WriteLine("Histórico " + historico);



        }
    }
}
