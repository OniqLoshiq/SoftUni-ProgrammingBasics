using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Rectangle_NxN
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string text = new string('*', n);
                Console.WriteLine(text);
            }
        }
    }
}
