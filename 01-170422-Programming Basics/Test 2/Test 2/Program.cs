using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            var num = int.Parse(Console.ReadLine());
            Console.Write("Square=");
            Console.WriteLine(num*num);

            Console.Write("b=");
            var b = int.Parse(Console.ReadLine());
            var area = b * b;
            Console.Write("Square=");
            Console.WriteLine(area);

            Console.Write("c=");
            var c = int.Parse(Console.ReadLine());
                        Console.WriteLine("Square={0}", c * c);
            


        }
    }
}
