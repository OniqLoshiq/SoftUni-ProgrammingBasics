using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Odd_even_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double evenSum = 0;
            double minOdd = 10000000000000000;
            double maxOdd = -10000000000000000;
            double minEven = 10000000000000000;
            double maxEven = -10000000000000000;

            for (int i = 1; i <= n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += a;
                  
                    if (maxEven < a)
                    { maxEven = a; }

                    if (minEven > a)
                    { minEven = a; }


                }
                else
                {
                    oddSum += a;
                   
                    if (maxOdd < a)
                    { maxOdd = a; }

                    if (minOdd > a)
                    { minOdd = a; }

                }
            }

            Console.WriteLine("OddSum={0}", oddSum);
            if (minOdd == 10000000000000000) Console.WriteLine("OddMin=No");
            else Console.WriteLine("OddMin={0}", minOdd);
            if (maxOdd == -10000000000000000) Console.WriteLine("OddMax=No");
            else Console.WriteLine("OddMax={0}", maxOdd);
            Console.WriteLine("EvenSum={0}", evenSum);
            if (minEven == 10000000000000000) Console.WriteLine("EvenMin=No");
            else Console.WriteLine("EvenMin={0}", minEven);
            if (maxEven == -10000000000000000) Console.WriteLine("EvenMax=No");
            else Console.WriteLine("EvenMax={0}", maxEven);


        }
    }
}
