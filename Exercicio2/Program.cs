using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            int num1, num2;
            //entrada de dados
            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            //processamento

            //saída
            Console.WriteLine("Numero 1:" + num1);
            Console.WriteLine("Numero 2:" + num2);

            Console.ReadKey();

        }
    }
}
