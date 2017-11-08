using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Sum_element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
                if (a > max)
                {
                    max = a;
                }
            }

            if ((sum - max) == max) Console.WriteLine("Yes Sum = {0}", max);
            else Console.WriteLine("No Diff = {0}", Math.Abs((sum - max) - max));
        }
    }
}
