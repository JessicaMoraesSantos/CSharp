using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.NumeroConta = 386;
            contaDaGabriela.NumeroAgencia = 123456;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.NumeroConta = 386;
            contaDaGabrielaCosta.NumeroAgencia = 123456;

            //Tipos de referência e tipos de valor

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta)); // Retorna falso porque cada nova instância referencia um endereço diferente na memória

            int idade = 27;
            int idadeMaisUmaVez = 27;
            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez)); // Retorna true

            contaDaGabriela = contaDaGabrielaCosta;

            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta); // Retorne true porque é a mesma referência

            Console.ReadLine();

        }
    }
}
