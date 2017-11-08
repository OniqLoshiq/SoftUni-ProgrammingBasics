using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Generator_of_stupid_passwords
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int chislo1 = 1; chislo1 <= n - 1; chislo1++)
            {
                for (int chislo2 = 1; chislo2 <= n - 1; chislo2++)
                {
                    int bukwa1 = (int)'a' - 1;

                    for (int i = 0; i < l; i++)
                    {
                        bukwa1++;
                        int bukwa2 = (int)'a' - 1;

                        for (int j = 0; j < l; j++)
                        {
                            bukwa2 += 1;

                            for (int k = 2; k <= n; k++)
                            {
                                if (k <= chislo1 || k <= chislo2)
                                {
                                    k = Math.Max(chislo2, chislo1) + 1;
                                }
                                Console.Write("{3}{4}{0}{1}{2} ", (char)bukwa1, (char)bukwa2, k, chislo1, chislo2);
                            }
                        }
                    }
                }
            }
        }

