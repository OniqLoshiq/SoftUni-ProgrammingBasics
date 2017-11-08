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
            int vineyard = int.Parse(Console.ReadLine());
            double grape = double.Parse(Console.ReadLine());
            int wine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double kgGrozde = vineyard * grape;
            double litraVino = (kgGrozde * 0.4 / 2.5);
            double ostatak = Math.Floor(Math.Abs(wine - litraVino));
            double ostatak1 = Math.Ceiling(Math.Abs(wine - litraVino));
            double chovek = Math.Ceiling(Math.Abs(wine - litraVino) / workers);

            if (litraVino >= wine)
            {
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(litraVino));
                Console.WriteLine($"{ostatak1} liters left -> {chovek} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {ostatak} liters wine needed.");
            }

        }
    }
}


