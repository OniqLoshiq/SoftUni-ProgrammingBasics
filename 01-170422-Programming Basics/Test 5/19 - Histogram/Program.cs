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
            double diap4 = 0.0;
            double diap5 = 0.0;


            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200) diap1 += 1;
                else if (num >= 200 && num <= 399) diap2 += 1;
                else if (num >= 400 && num <= 599) diap3 += 1;
                else if (num >= 600 && num <= 799) diap4 += 1;
                else if (num >= 800) diap5 += 1;
            }
            double p1 = diap1 / n * 100.0;
            double p2 = diap2 / n * 100.0;
            double p3 = diap3 / n * 100.0;
            double p4 = diap4 / n * 100.0;
            double p5 = diap5 / n * 100.0;


            Console.WriteLine("{0:0.00}%", p1);
            Console.WriteLine("{0:0.00}%", p2);
            Console.WriteLine("{0:0.00}%", p3);
            Console.WriteLine("{0:0.00}%", p4);
            Console.WriteLine("{0:0.00}%", p5);


        }
    }
}
