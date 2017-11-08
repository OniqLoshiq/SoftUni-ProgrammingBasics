using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07___Fruit_store
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double amount = double.Parse(Console.ReadLine());

            if (day == "sunday" || day == "saturday")
            {
                if (fruit == "banana") Console.WriteLine("{0:f2}", (amount * 2.7));
                else if (fruit == "apple") Console.WriteLine("{0:f2}", (amount * 1.25));
                else if (fruit == "orange") Console.WriteLine("{0:f2}", (amount * 0.9));
                else if (fruit == "grapefruit") Console.WriteLine("{0:f2}", (amount * 1.6));
                else if (fruit == "kiwi") Console.WriteLine("{0:f2}", (amount * 3));
                else if (fruit == "pineapple") Console.WriteLine("{0:f2}", (amount * 5.6));
                else if (fruit == "grapes") Console.WriteLine("{0:f2}", (amount * 4.2));

            }
            else if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                if (fruit == "banana") Console.WriteLine("{0:f2}", (amount * 2.5));
                else if (fruit == "apple") Console.WriteLine("{0:f2}", (amount * 1.2));
                else if (fruit == "orange") Console.WriteLine("{0:f2}", (amount * 0.85));
                else if (fruit == "grapefruit") Console.WriteLine("{0:f2}", (amount * 1.45));
                else if (fruit == "kiwi") Console.WriteLine("{0:f2}", (amount * 2.7));
                else if (fruit == "pineapple") Console.WriteLine("{0:f2}", (amount * 5.5));
                else if (fruit == "grapes") Console.WriteLine("{0:f2}", (amount * 3.85));
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
