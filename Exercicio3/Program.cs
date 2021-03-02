using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            int num1, num2, soma;
            //entrada de dados
            Console.WriteLine("Digite um número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            num2 = int.Parse(Console.ReadLine());
            //processamento
            soma = num1 * num2;
            //saída
            Console.WriteLine("O resultado da multiplicação entre " + num1 + " e " + num2 + " é igual: " + soma);
            Console.ReadKey();
        }
    }
}
