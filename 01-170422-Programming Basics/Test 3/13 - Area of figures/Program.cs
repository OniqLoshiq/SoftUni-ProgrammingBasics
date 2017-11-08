using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fig = Console.ReadLine();

            if (fig == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * a), 3));
            }
            else if (fig == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * b), 3));
            }
            else if (fig == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((Math.PI * a * a), 3));
            }
            else if (fig == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((a * b / 2), 3));
            }



        }
    }
}
