using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8___Odd_even_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    int b = int.Parse(Console.ReadLine());
                    evenSum += b;
                }
                else
                {
                    int c = int.Parse(Console.ReadLine());
                    oddSum += c;
                }
            }

            if (oddSum == evenSum) Console.WriteLine("Yes Sum = {0}", oddSum);
            else Console.WriteLine("No Diff = {0}", Math.Abs(oddSum - evenSum));

        }
    }
}
