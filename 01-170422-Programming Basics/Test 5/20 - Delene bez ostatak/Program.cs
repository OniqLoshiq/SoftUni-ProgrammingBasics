using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            double diap1 = 0.0;
            double diap2 = 0.0;
            double diap3 = 0.0;



            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0) diap1 += 1;
                if (num % 3 == 0) diap2 += 1;
                if (num % 4 == 0) diap3 += 1;

            }
            double p1 = diap1 / n * 100.0;
            double p2 = diap2 / n * 100.0;
            double p3 = diap3 / n * 100.0;



            Console.WriteLine("{0:0.00}%", p1);
            Console.WriteLine("{0:0.00}%", p2);
            Console.WriteLine("{0:0.00}%", p3);



        }
    }
}
