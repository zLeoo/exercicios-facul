using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            float raio, resultado;
            //entrada de dados
            Console.WriteLine("Vamos descobrir a área de uma circunferência!");
            Console.WriteLine("Digite o raio: ");
            raio = float.Parse(Console.ReadLine());

            //processamento
            resultado = 3.14159f * (raio * raio);

            //saída
            Console.WriteLine("A área da circunferência é " + resultado);
            Console.ReadKey();




        }
    }
}
