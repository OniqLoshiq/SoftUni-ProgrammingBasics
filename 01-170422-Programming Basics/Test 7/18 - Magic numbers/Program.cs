using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18___Magic_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int chislo1 = 1; chislo1 <= 9; chislo1++)
            {
                for (int chislo2 = 1; chislo2 <= 9; chislo2++)
                {
                    for (int chislo3 = 1; chislo3 <= 9; chislo3++)
                    {
                        for (int chislo4 = 1; chislo4 <= 9; chislo4++)
                        {
                            if (n % chislo1 == 0 && n % chislo2 == 0 && n % chislo3 == 0 && n % chislo4 == 0)
                            {
                                Console.Write("{0}{1}{2}{3} ", chislo1, chislo2, chislo3, chislo4);
                            }
                        }
                    }
                }
            }
        }
    }
}
