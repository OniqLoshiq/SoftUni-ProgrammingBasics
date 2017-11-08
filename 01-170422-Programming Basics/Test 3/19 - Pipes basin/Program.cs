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
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double Pipe1 = P1 * H;
            double Pipe2 = P2 * H;
            double total = Pipe1 + Pipe2;
            double x = Math.Floor(total / V * 100);
            double y = Math.Floor(Pipe1 / total * 100);
            double z = Math.Floor(Pipe2 / total * 100);

            if (V >= total)
            {
                Console.WriteLine($"The pool is {x}% full. Pipe 1: {y}%. Pipe 2: {z}%.");
            }
            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", H, total - V);
            }
        }
    }
}


