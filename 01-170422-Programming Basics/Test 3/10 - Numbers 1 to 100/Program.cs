using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string small = "Less than 100";
            string between = "Between 100 and 200";
            string greater = "Greater than 200";

            if (num < 100)
            {
                Console.WriteLine(small);
            }
            else if (num > 200)
            {
                Console.WriteLine(greater);
            }
            else
            {
                Console.WriteLine(between);
            }







        }
    }
}
