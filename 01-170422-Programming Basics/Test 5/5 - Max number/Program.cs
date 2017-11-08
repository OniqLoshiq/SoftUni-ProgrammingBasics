using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___Max_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int n1 = int.Parse(Console.ReadLine());
            int max = n1;

            for (int i = 1; i <= n - 1 ; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a > n1) max = a;
            }
            Console.WriteLine(max);

        }
    }
}
