using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            float num1, resultado;
            //entrada de dados
            Console.WriteLine("Digite uma temperatura em graus fahrenheit: ");
            num1 = float.Parse(Console.ReadLine());
            //processamento
            resultado = (num1 -32) * 5/9;
            //saída
            Console.WriteLine("A temperatura em celsius é " + resultado);
            Console.ReadKey();

        }
    }
}
