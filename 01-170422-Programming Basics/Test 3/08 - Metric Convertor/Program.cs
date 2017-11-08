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
            double a = double.Parse(Console.ReadLine());
            string inp = Console.ReadLine();
            string outp = Console.ReadLine();

            double edinica = 0;
            double edinicaOut = 0;


            if (inp == "m")
            {
                edinica = a;
            }
            else if (inp == "km")
            {
                edinica = a / 0.001;
            }
            else if (inp == "mm")
            {
                edinica = a / 1000;
            }
            else if (inp == "cm")
            {
                edinica = a / 100;
            }
            else if (inp == "mi")
            {
                edinica = a / 0.000621371192;
            }
            else if (inp == "in")
            {
                edinica = a / 39.3700787;
            }
            else if (inp == "ft")
            {
                edinica = a / 3.2808399;
            }
            else if (inp == "yd")
            {
                edinica = a / 1.0936133;
            }

            if (outp == "m")
            {
                edinicaOut = edinica;
            }
            else if (outp == "km")
            {
                edinicaOut = edinica * 0.001;
            }
            else if (outp == "mm")
            {
                edinicaOut = edinica * 1000;
            }
            else if (outp == "cm")
            {
                edinicaOut = edinica * 100;
            }
            else if (outp == "mi")
            {
                edinicaOut = edinica * 0.000621371192;
            }
            else if (outp == "in")
            {
                edinicaOut = edinica * 39.3700787;
            }
            else if (outp == "ft")
            {
                edinicaOut = edinica * 3.2808399;
            }
            else if (outp == "yd")
            {
                edinicaOut = edinica * 1.0936133;
            }

            Console.WriteLine(($"{edinicaOut} {outp}"));




        }
    }
}
