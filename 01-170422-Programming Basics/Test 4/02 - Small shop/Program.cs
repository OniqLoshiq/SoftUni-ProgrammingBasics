using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Small_shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if (city == "Sofia")
            {
                if (product == "coffee") Console.WriteLine(amount * 0.5);
                else if (product == "water") Console.WriteLine(amount * 0.8);
                else if (product == "beer") Console.WriteLine(amount * 1.2);
                else if (product == "sweets") Console.WriteLine(amount * 1.45);
                else if (product == "peanuts") Console.WriteLine(amount * 1.6);
            }
            if (city == "Plovdiv")
            {
                if (product == "coffee") Console.WriteLine(amount * 0.4);
                else if (product == "water") Console.WriteLine(amount * 0.7);
                else if (product == "beer") Console.WriteLine(amount * 1.15);
                else if (product == "sweets") Console.WriteLine(amount * 1.3);
                else if (product == "peanuts") Console.WriteLine(amount * 1.5);
            }
            if (city == "Varna")
            {
                if (product == "coffee") Console.WriteLine(amount * 0.45);
                else if (product == "water") Console.WriteLine(amount * 0.7);
                else if (product == "beer") Console.WriteLine(amount * 1.1);
                else if (product == "sweets") Console.WriteLine(amount * 1.35);
                else if (product == "peanuts") Console.WriteLine(amount * 1.55);
            }
        }
    }
}
