using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int x1 = 3 * h;
            int y1 = h;
            int x2 = h;
            int x3 = 2 * h;
            int y2 = h;
            int y3 = 4 * h;

            if (((x > 0 && x < x1) && (y > 0 && y < y1)) || ((x > x2 && x < x3) && (y >= y2 && y < y3)))
            {
                Console.WriteLine("inside");
            }
            else if (((x >= 0 && x <= x1) && y == 0) || (((x >= 0 && x <= x2) || (x >= x3 && x <= x1)) && y == y2))
            {
                Console.WriteLine("border");
            }
            else if (((x == 0 || x == x1) && (y >= 0 && y <= h)))
            {
                Console.WriteLine("border");
            }
            else if (((x == x2 || x == x3) && (y >= y2 && y <= y3)) || (y == y3 && (x >= x2 && x <= x3)))
            {
                Console.WriteLine("border");
            }
            else
            {
                Console.WriteLine("outside");
            }
        }
    }
}
