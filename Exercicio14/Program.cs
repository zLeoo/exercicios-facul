using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            float cotacao, resultado, quantidade;
            //entrada de dados
            Console.WriteLine("Digite a cotação do dolar atual");
            cotacao = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos dolar você tem");
            quantidade = float.Parse(Console.ReadLine());
            //processamento
            resultado = cotacao * quantidade;
            //saída
            Console.WriteLine("Você tem "+ resultado + " reais");
            Console.ReadKey();

        }
    }
}
