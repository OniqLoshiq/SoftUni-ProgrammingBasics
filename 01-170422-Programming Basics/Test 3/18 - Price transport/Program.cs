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
            double km = double.Parse(Console.ReadLine());
            string tarifa = Console.ReadLine();

            double taxiDen = 0.7 + km * 0.79;
            double taxiNosht = 0.7 + km * 0.9;
            double bus = 0.09 * km;
            double train = 0.06 * km;

            if (km <= 19)
            {
                if (tarifa == "day") Console.WriteLine(taxiDen);
                else if (tarifa == "night") Console.WriteLine(taxiNosht);
            }
            else
            {
                if (km <= 99) Console.WriteLine(bus);
                else if (km >= 100) Console.WriteLine(train);

            }

        }
    }
}


