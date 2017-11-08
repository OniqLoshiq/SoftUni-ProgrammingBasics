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

            int chas = int.Parse(Console.ReadLine());
            int minuti = int.Parse(Console.ReadLine());

            int a = chas * 60 + minuti + 15;
            int b = a / 60;
            int c = a - b * 60;

            if (b > 23)
            {
                Console.WriteLine("0:{0:00}", c);
            }
            else
            {
                Console.WriteLine($"{b}:{c:00}");
            }


        }
    }
}
