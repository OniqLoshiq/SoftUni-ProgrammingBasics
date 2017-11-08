using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_RadToGrad
{
    class Program
    {
        static void Main(string[] args)
        {
            double R = double.Parse(Console.ReadLine());
            double G =  R * 180 / Math.PI;
            Console.WriteLine(Math.Round(G,2));
        }
    }
}
