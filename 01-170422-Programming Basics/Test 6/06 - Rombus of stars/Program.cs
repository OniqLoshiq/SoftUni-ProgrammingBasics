using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06___Rombus_of_stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l <= i; l++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" ");
                }
                for (int l = n - i; l >= 1; l--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

        }
    }
}
