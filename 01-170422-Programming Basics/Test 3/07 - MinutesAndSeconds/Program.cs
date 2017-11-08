using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___MinutesAndSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int total = a + b + c;

            int minutes = total / 60;
            int seconds = total % 60;

            Console.WriteLine(($"{minutes}:{seconds:00}"));
        }
    }
}
