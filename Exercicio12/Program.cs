using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            float num1, resultado;

            //entrada de dados
            Console.WriteLine("Digite um número: ");
            num1 = float.Parse(Console.ReadLine());

            //processamento
            resultado = num1 % 6;

            //saída
            Console.WriteLine("O resto da divisão de "+ num1 + "por 6 é igual a " + resultado);
            Console.ReadKey();
        }
    }
}
