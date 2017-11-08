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

            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            if (sales >= 0 && sales <= 500)
            {
                if (city == "sofia") Console.WriteLine(Math.Round((sales * 0.05), 2));
                else if (city == "plovdiv") Console.WriteLine(Math.Round((sales * 0.055), 2));
                else if (city == "varna") Console.WriteLine(Math.Round((sales * 0.045), 2));
                else if (city != "sofia" || city != "plovdiv" || city != "varna") Console.WriteLine("error");

            }
            if (sales > 500 && sales <= 1000)
            {
                if (city == "sofia") Console.WriteLine(Math.Round((sales * 0.07), 2));
                else if (city == "plovdiv") Console.WriteLine(Math.Round((sales * 0.08), 2));
                else if (city == "varna") Console.WriteLine(Math.Round((sales * 0.075), 2));
                else if (city != "sofia" || city != "plovdiv" || city != "varna") Console.WriteLine("error");

            }
            if (sales > 1000 && sales <= 10000)
            {
                if (city == "sofia") Console.WriteLine(Math.Round((sales * 0.08), 2));
                else if (city == "plovdiv") Console.WriteLine(Math.Round((sales * 0.12), 2));
                else if (city == "varna") Console.WriteLine(Math.Round((sales * 0.1), 2));
                else if (city != "sofia" || city != "plovdiv" || city != "varna") Console.WriteLine("error");

            }
            if (sales > 10000)
            {
                if (city == "sofia") Console.WriteLine(Math.Round((sales * 0.12), 2));
                else if (city == "plovdiv") Console.WriteLine(Math.Round((sales * 0.145), 2));
                else if (city == "varna") Console.WriteLine(Math.Round((sales * 0.13), 2));
                else if (city != "sofia" || city != "plovdiv" || city != "varna") Console.WriteLine("error");
            }
            if (sales < 0) Console.WriteLine("error");



        }
    }
}
