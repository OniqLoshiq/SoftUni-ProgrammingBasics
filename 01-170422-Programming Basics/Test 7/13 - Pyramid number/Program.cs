using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13___Pyramid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            bool shouldBreak = false;
            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows ; cols++)
                {
                    num++;
                    Console.Write($"{num} ");
                    if (num == n)
                    {
                        shouldBreak = true;
                        break;
                    }
                }
                Console.WriteLine();
                if (shouldBreak) break;
            }
        }
    }
}
