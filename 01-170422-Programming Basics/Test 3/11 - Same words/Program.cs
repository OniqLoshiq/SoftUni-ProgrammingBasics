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
            string inp = Console.ReadLine();
            string outp = Console.ReadLine();

            inp = inp.ToLower();
            outp = outp.ToLower();

            if (inp == outp)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }






        }
    }
}
