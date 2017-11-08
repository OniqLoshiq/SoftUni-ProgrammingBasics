using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___Diamonds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int stars = 0;
            int blank = 0;
            int blank1 = -1;
            int extra = n - 2;

            if (n % 2 == 0) stars = 2;
            else stars = 1;

            if (n <= 2)
                Console.WriteLine("{0}{1}{0}", new string('-', (n - stars) / 2), new string('*', stars));

            else
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (n - stars) / 2), new string('*', stars));

                if (n % 2 == 0)
                {
                    for (int i = 1; i <= (n - 2) / 2; i++)
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', ((n - stars) / 2) - (i)), new string('-', (blank += 2)));
                    }
                    for (int i = 1; i < (n - 2) / 2; i++)
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', i), new string('-', extra -= 2));
                    }
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - stars) / 2), new string('*', stars));
                }
                else
                {
                    for (int i = 1; i <= (n - 2) / 2 + 1; i++)
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', ((n - stars) / 2) - (i)), new string('-', (blank1 += 2)));
                    }
                    for (int i = 1; i < (n - 2) / 2 + 1; i++)
                    {
                        Console.WriteLine("{0}*{1}*{0}", new string('-', i), new string('-', extra -= 2));
                    }
                    Console.WriteLine("{0}{1}{0}", new string('-', (n - stars) / 2), new string('*', stars));

                }
            }
        }
    }
}

