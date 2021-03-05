using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            float resultado, valor,taxa;
            int tempo;
            //entrada de dados
            Console.WriteLine("Vamos descobrir o valor das suas prestações em atraso!!!");
            Console.WriteLine("Digite o valor: ");
            valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a taxa: ");
            taxa = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a digite o tempo: ");
            tempo = int.Parse(Console.ReadLine());

            //processamento
            resultado = valor + (valor * (taxa / 100) * tempo);
            //saída
            Console.WriteLine("O valor da prestação será R$ "+resultado);
            Console.ReadLine();

        }
    }
}
