﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LacoDeRepeticaoFor
{ 
class Progrma
        {
            static void Main(String[] args)
            {
                for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
                {
                    for (int contador = 0; contador <= 10; contador++)
                    {
                        Console.Write(multiplicador + " * " + contador + " = " + multiplicador * contador);
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
    