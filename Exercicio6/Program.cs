using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //criação das variáveis
            float raio, altura, volume;
            //entrada de dados
            Console.WriteLine("Vamos descobrir o volume de uma lata de óleo!");
            Console.WriteLine("Digite o raio da lata (cm)");
            raio = float.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite a altura da lata (cm) ");
            altura = float.Parse(Console.ReadLine());
            //processamento
            volume = 3.14159f * raio * altura;
            //saída

            Console.WriteLine("O volume da lata é de " + volume + "cm");

            Console.ReadKey();

        }
    }
}
