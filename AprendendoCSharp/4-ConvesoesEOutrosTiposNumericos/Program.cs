using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConvesoesEOutrosTiposNumericos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis do tipo float, bem como do tipo int, armazenam 32 bits
            // Variáveis do tipo double armazenam 64 bits 
            float pontoFlutuante = 3.14f; // Conversão para float

            double salario = 1250.70;
            int valor = (int) salario;

            Console.WriteLine(valor);

            double valor1 = 0.1;
            double valor2 = 0.2;
            double total = valor1 + valor2;

            Console.WriteLine(total);

            Console.WriteLine("Execução finalizada. Tecle 'enter' para sair...");
            Console.ReadLine();
        }
    }
}
