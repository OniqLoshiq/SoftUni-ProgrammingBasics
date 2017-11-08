using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
            double total = 0.0;

            for (int i = 1; i <= parts; i++)
            {
                int points = int.Parse(Console.ReadLine());

                if (i % 2 == 0) points *= 2;
                total += points;
            }
            Console.WriteLine("The project prize was {0:f2} lv.", total * money);
        }
    }
}
