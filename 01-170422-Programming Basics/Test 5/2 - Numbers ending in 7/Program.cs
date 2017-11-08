using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Numbers_ending_in_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                if ( i % 10 == 7)
                    Console.WriteLine(i);
            }

        }
    }
}
