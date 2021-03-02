using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            float a, b, c;
            //entrada de dados
            Console.WriteLine("Invertendo os valores :D");
            Console.WriteLine("Digite um número: ");
            a = float.Parse(Console.ReadLine()); 
            Console.WriteLine("Digite outro número: ");
            b = float.Parse(Console.ReadLine()); 
            //processamento
            c = a; 
            a = b;  
            b = c; 
        
            //saída
            Console.WriteLine("Os valores invertidos são " + a + " e " + b);

            Console.ReadKey();



        }
    }
}
