using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o Projeto 11");

            double valorInvestido = 1000;

            for (int i = 1; i <= 12; i++)
            {
                valorInvestido = valorInvestido  + valorInvestido * 0.0036;
                Console.WriteLine("Após " + i + " meses, você terá R$ " + valorInvestido);
            }

            Console.ReadLine();
        }
    }
}
