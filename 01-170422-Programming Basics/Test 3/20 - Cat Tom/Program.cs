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
            int days = int.Parse(Console.ReadLine());
            int restD = days * 127;
            int workD = (365 - days) * 63;
            int pet = restD + workD;
            int run = Math.Abs(pet - 30000);
            int h = run / 60;
            int m = run - h * 60;

            if (pet >= 30000)
            {
                Console.WriteLine("Tom will run away");

                Console.WriteLine($"{h} hours and {m} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{h} hours and {m} minutes less for play");
            }


        }
    }
}


