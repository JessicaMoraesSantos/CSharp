using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_TestaPontoFlutuante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double salario = 1250.70;
            Console.WriteLine("Meu salário é " + salario);

            int divisaoInt = 5 / 2;
            Console.WriteLine("Resultado da divisão " + divisaoInt);

            double divisaoDouble = 5.0 / 2; 
            // Uma divisão de números inteiros sempre retornará um resultado inteiro
            // Para uma saída com casa decimal deve haver a entrada de um decimal
            Console.WriteLine("Resultado da divisão " + divisaoDouble);

            Console.WriteLine("Execução finalizada. Tecle 'enter' para sair...");
            Console.ReadLine();
        }
    }
}
