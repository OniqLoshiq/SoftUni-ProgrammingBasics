﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();

            if (gender == "f")
            {
                if (age < 16) Console.WriteLine("Miss");
                else if (age >= 16) Console.WriteLine("Ms.");
            }
            else
            {
                if (age < 16) Console.WriteLine("Master");
                else if (age >= 16) Console.WriteLine("Mr.");
            }
        }
    }
}
