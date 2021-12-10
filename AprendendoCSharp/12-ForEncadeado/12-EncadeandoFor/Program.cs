using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_EncadeandoFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for(int i = 1; i <= 5; i++)
            {
                for(int cont = 1; cont <= 12; cont++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }
            Console.WriteLine("Ao término do investimento você terá R$ " + valorInvestido);
            Console.ReadLine(); 
        }
    }
}
