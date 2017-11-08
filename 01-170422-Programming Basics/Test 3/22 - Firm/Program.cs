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
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hardWorkers = int.Parse(Console.ReadLine());
            double workingHours = days * 0.9 * 8;
            double extraHours = hardWorkers * 2 * days;
            double totalHours = Math.Floor(workingHours + extraHours);
            double rest = Math.Abs(hours - totalHours);

            if (totalHours >= hours)
            {
                Console.WriteLine($"Yes!{rest} hours left.");
            }
            else
            {
                Console.WriteLine($"Not enough time!{rest} hours needed.");
            }
        }
    }
}


