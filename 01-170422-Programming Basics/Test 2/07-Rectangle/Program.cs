﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double S = Math.Abs(x1 - x2) * Math.Abs(y1 - y2);
            double A = 2 * Math.Abs(x1 - x2) + 2 * Math.Abs(y1 - y2);
            Console.WriteLine(S);
            Console.WriteLine(A);
        }
    }
}
