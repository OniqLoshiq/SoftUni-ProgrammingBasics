using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___Fortress
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inner = 2 * n - (n / 2) * 2 - 4;
            if (inner < 0) inner = 0;

            Console.WriteLine("/{0}\\{1}/{0}\\", new string('^', n / 2), new string('_', inner));

            if (inner == 0)
            {
                for (int i = 0; i < n - 2; i++)
                {
                    Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
                }
                Console.WriteLine("\\{0}/\\{0}/", new string('_', n / 2));
            }
            else
            {
                for (int i = 0; i < n - 3; i++)
                {
                    Console.WriteLine("|{0}|", new string(' ', 2 * n - 2));
                }
                Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2 + 1), new string('_', inner));
                Console.WriteLine("\\{0}/{1}\\{0}/", new string('_', n / 2), new string(' ', inner));
            }

        }
    }
}
