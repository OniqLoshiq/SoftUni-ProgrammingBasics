using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6___Min_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int n1 = int.Parse(Console.ReadLine());
            int min = n1;

            for (int i = 0; i < n - 1; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < min) min = a;
            }
            Console.WriteLine(min);

        }
    }
}
