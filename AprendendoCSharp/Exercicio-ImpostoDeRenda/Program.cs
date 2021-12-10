using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioImpostoDeRenda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double salario = 5000.0;

            if (salario >= 1900.0 && salario <= 2800.0)
            {
                Console.WriteLine("A sua alíquota é de 7,5%");
                Console.WriteLine("Dedução na declaração no valor de R$142");
            }
            else if (salario > 2800 && salario <= 3751)
            {
                Console.WriteLine("A sua alíquota é de 15%");
                Console.WriteLine("Dedução na declaração no valor de R$350");
            }
            else if (salario > 3751 && salario <= 4664)
            {
                Console.WriteLine("A sua alíquota é de 22,5%");
                Console.WriteLine("Dedução na declaração no valor de R$636");
            }
            Console.ReadLine();
        }
    }
}
