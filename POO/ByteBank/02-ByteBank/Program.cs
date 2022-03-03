
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TIPOS DE REFERÊNCIA E TIPOS DE VALOR
            ContaCorrente conta = new ContaCorrente();

            Console.WriteLine("Saldo: " + conta.saldo);
            Console.WriteLine("Conta: " + conta.NumeroConta); // Imprime valor default da classe = 0
            Console.ReadLine();
        }
    }
}
