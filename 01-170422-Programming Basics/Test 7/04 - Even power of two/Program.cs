﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Even_power_of_two
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n; i+=2)
            {
                double a = Math.Pow(2, i );
                Console.WriteLine(a);
            }

        }
    }
}
