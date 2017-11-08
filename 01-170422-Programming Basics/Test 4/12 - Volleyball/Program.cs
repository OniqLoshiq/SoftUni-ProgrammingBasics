using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine().ToLower();
            int freeDays = int.Parse(Console.ReadLine());
            int travelHome = int.Parse(Console.ReadLine());

            double sofia = (48.0 - travelHome) * 3 / 4;
            double holiday = freeDays * 2.0 / 3;
            double totalNormal = Math.Floor(sofia + holiday + travelHome);
            double totalLeap = Math.Floor((sofia + holiday + travelHome) * 1.15);

            if (year == "leap") Console.WriteLine(totalLeap);
            else if (year == "normal") Console.WriteLine(totalNormal);

        }
    }
}
