﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplosde3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 100; i++)
            {   
                if  (i % 3 == 0) 
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
