using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Hotel_rooms
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int days = int.Parse(Console.ReadLine());

            double studio = 0.00;
            double apartment = 0.00;


            if ((month == "may" || month == "october") && days <= 7)
            {
                studio = days * 50;
                apartment = days * 65;
            }
            else if ((month == "may" || month == "october") && days <= 14)
            {
                studio = days * 50 * 0.95;
                apartment = days * 65;
            }
            else if ((month == "may" || month == "october") && days > 14)
            {
                studio = days * 50 * 0.7;
                apartment = days * 65 * 0.9;
            }
            else if ((month == "june" || month == "september") && days <= 14)
            {
                studio = days * 72.50;
                apartment = days * 68.70;
            }
            else if ((month == "june" || month == "september") && days > 14)
            {
                studio = days * 75.20 * 0.8;
                apartment = days * 68.70 * 0.9;
            }
            else if ((month == "july" || month == "august") && days > 14)
            {
                studio = days * 76;
                apartment = days * 77 * 0.9;
            }
            else if ((month == "july" || month == "august") && days <= 14)
            {
                studio = days * 76;
                apartment = days * 77;
            }
            Console.WriteLine("Apartment: {0:f2} lv.", apartment);
            Console.WriteLine("Studio: {0:f2} lv.", studio);

        }
    }
}
