using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            int dias, anos, mes;
            //entrada de dados
            Console.WriteLine("Digite sua idade em dias");
            dias = int.Parse(Console.ReadLine());


            //processamento
            anos = dias / 365;
            mes = dias % 365 / 30;
            dias = (dias % 365) % 30;



            //saída
            Console.WriteLine("Parabéns você já viveu " + anos + " ano(s)" + "," + mes + " mes(es)" + " e " + dias + " dia(s)") ;

            Console.ReadKey();
        }
    }
}
