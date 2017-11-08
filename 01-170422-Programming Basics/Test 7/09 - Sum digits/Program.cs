using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09___Sum_digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string b = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < b.Length; i++)
            {
                int current = int.Parse(b[i].ToString());

                sum += current;
            }
            Console.WriteLine(sum);
        }
    }
}
