using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_8
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
            resultado = num1 * num1;
            //saída
            Console.WriteLine("O quadrado de " + num1 + " é " + resultado);


            Console.ReadKey();
        }
    }
}
