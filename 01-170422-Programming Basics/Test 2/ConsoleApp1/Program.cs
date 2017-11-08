using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches=");
            var inc = double.Parse(Console.ReadLine());
            var cm = inc * 2.54;
            Console.Write("Centimeters=");
            Console.WriteLine(cm);
        }
    }
}
