using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            int dias, anos, mes, resultado;
            //entrada de dados
            Console.WriteLine("Digite sua idade em dias");
            dias = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua idade em meses");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite sua idade em anos");
            anos = int.Parse(Console.ReadLine());

            //processamento
            resultado = (anos * 365) + (mes * 30) + dias;

            //saída
            Console.WriteLine("Parabéns você já viveu "+ resultado + " dia(s)");

            Console.ReadKey();

        }
    }
}
