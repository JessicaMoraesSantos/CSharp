﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_CriandoVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 2 - Criando variaveis");


            int idade = 32;
            Console.WriteLine("Idade = " + idade);

            idade = 10;
            Console.WriteLine(idade);

            idade = 10 + 5;
            Console.WriteLine(idade);

            Console.WriteLine("Execução finalizada. Tecle 'enter' para sair...");
            Console.ReadLine();
        }
    }
}
