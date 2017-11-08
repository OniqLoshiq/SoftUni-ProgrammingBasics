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
            int num = int.Parse(Console.ReadLine());
            string nula = "zero";
            string edno = "one";
            string dve = "two";
            string tri = "three";
            string chetiri = "four";
            string pet = "five";
            string shest = "six";
            string sedem = "seven";
            string osem = "eight";
            string devet = "nine";
            string deset = "ten";
            string edinadeset = "eleven";
            string dvanadeset = "twelve";
            string trinadeset = "thirteen";
            string chetirinadeset = "fourteen";
            string petnadeset = "fifteen";
            string shesnadeset = "sixteen";
            string sedemnadeset = "seventeen";
            string osemnadeset = "eighteen";
            string devetnadeset = "nineteen";
            string dvaideset = "twenty";
            string trideset = "thirty";
            string chetirset = "forty";
            string petdeset = "fifty";
            string shestdeset = "sixty";
            string sedemdeset = "seventy";
            string osemdeset = "eighty";
            string devedeset = "ninety";
            string sto = "one hundred";

            int a = num / 10;
            int b = num % 10;
            string c = "";
            string d = "";



            if (num >= 0 && num <= 100)
            {
                if (num < 10)
                {
                    if (b == 0) c = nula;
                    else if (b == 1) c = edno;
                    else if (b == 2) c = dve;
                    else if (b == 3) c = tri;
                    else if (b == 4) c = chetiri;
                    else if (b == 5) c = pet;
                    else if (b == 6) c = shest;
                    else if (b == 7) c = sedem;
                    else if (b == 8) c = osem;
                    else if (b == 9) c = devet;

                    Console.WriteLine(c);
                }

                else
                {
                    if (num < 20)
                    {
                        if (b == 0) c = deset;
                        else if (b == 1) c = edinadeset;
                        else if (b == 2) c = dvanadeset;
                        else if (b == 3) c = trinadeset;
                        else if (b == 4) c = chetirinadeset;
                        else if (b == 5) c = petnadeset;
                        else if (b == 6) c = shesnadeset;
                        else if (b == 7) c = sedemnadeset;
                        else if (b == 8) c = osemnadeset;
                        else if (b == 9) c = devetnadeset;

                        Console.WriteLine(c);
                    }
                    else
                    {
                        if (num >= 20 && b == 0)
                        {
                            if (a == 2) c = dvaideset;
                            else if (a == 3) c = trideset;
                            else if (a == 4) c = chetirset;
                            else if (a == 5) c = petdeset;
                            else if (a == 6) c = shestdeset;
                            else if (a == 7) c = sedemdeset;
                            else if (a == 8) c = osemdeset;
                            else if (a == 9) c = devedeset;
                            else if (a == 10) c = sto;

                            Console.WriteLine(c);
                        }
                        else
                        {
                            if (a == 2) c = dvaideset;
                            else if (a == 3) c = trideset;
                            else if (a == 4) c = chetirset;
                            else if (a == 5) c = petdeset;
                            else if (a == 6) c = shestdeset;
                            else if (a == 7) c = sedemdeset;
                            else if (a == 8) c = osemdeset;
                            else if (a == 9) c = devedeset;
                            else if (a == 10) c = sto;

                            if (b == 1) d = edno;
                            else if (b == 2) d = dve;
                            else if (b == 3) d = tri;
                            else if (b == 4) d = chetiri;
                            else if (b == 5) d = pet;
                            else if (b == 6) d = shest;
                            else if (b == 7) d = sedem;
                            else if (b == 8) d = osem;
                            else if (b == 9) d = devet;

                            Console.WriteLine($"{c} {d}");
                        }

                    }
                }


            }

            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
