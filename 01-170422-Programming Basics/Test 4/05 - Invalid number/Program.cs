using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Invalid_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a == 0 || (a >= 100 && a <= 200))
            {

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
