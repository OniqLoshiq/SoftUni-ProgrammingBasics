﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Number_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int num = 0;

            for (int rows = 0; rows < n; rows++)
            {
                for (int cols = 0; cols < n; cols++)
                {
                    num = cols + rows + 1;
                    if (num > n) num = 2 * n - num;
                    Console.Write("{0} ", num);
                }
                Console.WriteLine();
            }
        }
    }
}
