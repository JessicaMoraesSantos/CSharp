using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(); //new = criar objeto

            conta.titular = "Luan";
            conta.NumeroAgencia = 0001;
            conta.NumeroConta = 123456;
            conta.saldo = 5151;

            Console.WriteLine("Titular: " + conta.titular);
            Console.WriteLine("Agencia: " + conta.NumeroAgencia);
            Console.WriteLine("Conta: " + conta.NumeroConta);
            Console.WriteLine("Saldo: " + conta.saldo);

            Console.ReadLine();
        }
    }
}
