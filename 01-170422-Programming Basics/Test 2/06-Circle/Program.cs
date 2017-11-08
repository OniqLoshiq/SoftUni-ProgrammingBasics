using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());
            double A = Math.PI * r * 2;
            double S = Math.PI * r * r;
            Console.WriteLine(S);
            Console.WriteLine(A);
        }
    }
}
