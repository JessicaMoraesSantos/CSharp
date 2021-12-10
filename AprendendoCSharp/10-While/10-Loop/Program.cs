using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto - 10 Calculo de Poupança");

            double valorInvestido = 1000;
            int contadorMes = 1;

            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036; 
            Console.WriteLine("Após " + contadorMes +  " mês você terá " + valorInvestido);

                contadorMes++;
            }

            


            Console.ReadLine();

        }
    }
}
