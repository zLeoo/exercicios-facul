using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            float num1, resultado;
            //entrada de dados
            Console.WriteLine("Digite uma temperatura em graus celsius: ");
            num1 = float.Parse(Console.ReadLine());
            //processamento
            resultado = (num1 * 9/5) + 32;
            //saída
            Console.WriteLine("A temperatura em fahrenheit é " + resultado);
            Console.ReadKey();

        }
    }
}
