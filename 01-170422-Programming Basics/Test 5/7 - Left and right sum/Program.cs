using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7___Left_and_right_sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int rightSum = 0;
            int leftSum = 0;

            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                rightSum += b;
            }

            for (int i = 0; i < n; i++)
            {
                int c = int.Parse(Console.ReadLine());
                leftSum += c;
            }

            if (leftSum == rightSum) Console.WriteLine("Yes, sum = {0}", rightSum);
            else Console.WriteLine("No, diff = {0}", Math.Abs(rightSum - leftSum));

        }
    }
}
