using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticket = Console.ReadLine().ToLower();
            int fen = int.Parse(Console.ReadLine());

            double travel1 = budget - budget * 0.75;
            double travel2 = budget - budget * 0.60;
            double travel3 = budget - budget * 0.50;
            double travel4 = budget - budget * 0.40;
            double travel5 = budget - budget * 0.25;
            double priceTicket = ticket == "vip" ? 499.99 : 249.99;
            double totalTicket = priceTicket * fen;
            double travel = 0.0;


            if (fen >= 1 && fen <= 4) { travel = travel1; }
            else if (fen <= 9) { travel = travel2; }
            else if (fen <= 24) { travel = travel3; }
            else if (fen <= 49) { travel = travel4; }
            else if (fen > 50) { travel = travel5; }

            if (totalTicket <= travel) Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Abs(travel - totalTicket));
            else Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Abs(travel - totalTicket));
        }
    }
}
