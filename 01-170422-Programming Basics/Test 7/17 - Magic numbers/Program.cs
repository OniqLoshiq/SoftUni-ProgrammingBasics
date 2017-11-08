using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Magic_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int product = 0;


            for (int chislo1 = 1; chislo1 <= 9; chislo1++)
            {
                for (int chislo2 = 1; chislo2 <= 9; chislo2++)
                {
                    for (int chislo3 = 1; chislo3 <= 9; chislo3++)
                    {
                        for (int chislo4 = 1; chislo4 <= 9; chislo4++)
                        {
                            for (int chislo5 = 1; chislo5 <= 9; chislo5++)
                            {
                                for (int chislo6 = 1; chislo6 <= 9; chislo6++)
                                {
                                    product = chislo1 * chislo2 * chislo3 * chislo4 * chislo5 * chislo6;
                                    if (product == n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", chislo1, chislo2, chislo3, chislo4, chislo5, chislo6);
                                    }

                                }
                            }
                        }
                    }
                }

            }
        }
    }
}
