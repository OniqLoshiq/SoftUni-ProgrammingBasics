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
            string pass = Console.ReadLine();
            string realPass = "s3cr3t!P@ssw0rd";

            if (pass == realPass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }






        }
    }
}
