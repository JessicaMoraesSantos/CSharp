using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 5 - Caracteres e Textos");

            char PrimeiraLetra = 'a';
            Console.WriteLine(PrimeiraLetra);

            // O tipo char guarda apenas um número da tabela ascii
            // Por isso, quando passamos um valor numérico, teremos como saída o caractere correspondente ao número na tabela ascii
            char valorTabela = (char)65;
            Console.WriteLine(valorTabela);

            string texto = "Alura cursos de tecnologia " + 2021;
            Console.WriteLine(texto);

            Console.WriteLine("Execução finalizada. Tecle 'enter' para finalizar...");
            Console.ReadLine();
        }
    }
}
