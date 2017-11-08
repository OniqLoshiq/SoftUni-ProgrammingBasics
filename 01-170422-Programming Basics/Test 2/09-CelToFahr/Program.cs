using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_CelToFahr
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = double.Parse(Console.ReadLine());
            Console.WriteLine(C * 1.8 +32);
        }
    }
}
