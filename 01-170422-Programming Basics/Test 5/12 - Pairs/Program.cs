using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int currentSum = a + b;
            int previousSum = 0;
            int diff1 = int.MinValue;
            int diff2 = 0;
            int counter = 1;

            for (int i = 1; i < n; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());

                previousSum = currentSum;
                currentSum = num1 + num2;
                diff2 = Math.Abs(previousSum - currentSum);
                counter += 1;

                if (diff2 >= diff1)
                {
                    diff1 = diff2;
                }
            }

            if (diff1 == 0 || counter == 1)
            {
                Console.WriteLine("Yes, value={0}", currentSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", diff1);
            }
        }
    }
}


