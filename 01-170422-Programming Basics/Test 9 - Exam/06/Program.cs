using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int controlNum = int.Parse(Console.ReadLine());

            int counterSum = 0;
            int counterProduct = 0;
            for (int a = 1; a <= 30; a++)
            {
                for (int b = 1; b <= 30; b++)
                {
                    for (int c = 1; c <= 30; c++)
                    {
                        int sum = a + b + c;
                        int product = a * b * c;
                        if ((a < b && b < c) && sum == controlNum)
                        {
                            counterSum++;
                            Console.WriteLine($"{a} + {b} + {c} = {sum}");
                        }
                        else if ((a > b && b > c) && product == controlNum)
                        {
                            counterProduct++;
                            Console.WriteLine($"{a} * {b} * {c} = {product}");
                        }
                    }
                }
            }
            if (counterProduct == 0 && counterSum == 0) Console.WriteLine("No!");
        }
    }
}
