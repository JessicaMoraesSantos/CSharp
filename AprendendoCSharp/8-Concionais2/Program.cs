using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Concionais2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 8 - Condicionais2");

            int idadeJoao = 10;
            // int quantidadePessoas = 1;
            bool acompanhado = false;

            if (idadeJoao >= 18 || acompanhado == true)
            {
                Console.WriteLine("João pode entrar.");
            }
            else
            {
                Console.WriteLine("João não pode entrar.");
            }
            Console.ReadLine();
        }


    }
}

