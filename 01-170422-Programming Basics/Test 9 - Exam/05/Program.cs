using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int a = -1;

            Console.WriteLine("{0}", new string('#', 4 * n + 1));

            for (int i = 1; i <= n; i++)
            {
                a += 2;
                if(i == n / 2 + 1)
                {
                    Console.WriteLine("{0}{1}{2}(@){2}{1}{0}", new string('.', i), new string('#', (2 * n + 1) - i * 2), new string(' ', n / 2 - 1));
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', i), new string('#', (2 * n + 1) - i * 2), new string(' ', a));
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('.', n + 1 + i),new string('#', 2 * n - 1 - 2 * i));
            }
        }
    }
}
