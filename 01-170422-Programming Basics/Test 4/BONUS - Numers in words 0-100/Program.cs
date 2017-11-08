using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BONUS___Numers_in_words_0_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int a = num / 10;
            int b = num % 10;
            int c = num % 10;

            string edinici = String.Empty;
            string mix = String.Empty;
            string desetici = String.Empty;

            switch (a)
            {
                case 2: desetici = "twenty"; break;
                case 3: desetici = "thirty"; break;
                case 4: desetici = "forty"; break;
                case 5: desetici = "fifty"; break;
                case 6: desetici = "sixty"; break;
                case 7: desetici = "seventy"; break;
                case 8: desetici = "eighty"; break;
                case 9: desetici = "ninety"; break;
                case 10: desetici = "one hundred"; break;
            }

            switch (b)
            {
                case 0: mix = "ten"; break;
                case 1: mix = "eleven"; break;
                case 2: mix = "twelve"; break;
                case 3: mix = "thirteen"; break;
                case 4: mix = "fourteen"; break;
                case 5: mix = "fifteen"; break;
                case 6: mix = "sixteen"; break;
                case 7: mix = "seventeen"; break;
                case 8: mix = "eighteen"; break;
                case 9: mix = "nineteen"; break;
            }

            switch (c)
            {
                case 0: edinici = "zero"; break;
                case 1: edinici = "one"; break;
                case 2: edinici = "two"; break;
                case 3: edinici = "three"; break;
                case 4: edinici = "four"; break;
                case 5: edinici = "five"; break;
                case 6: edinici = "six"; break;
                case 7: edinici = "seven"; break;
                case 8: edinici = "eight"; break;
                case 9: edinici = "nine"; break;
            }

            if (num >= 0 && num <= 100)
            {
                if (num < 10) Console.WriteLine(edinici);
                else if (num <= 19) Console.WriteLine(mix);
                else if (num >= 20 && b == 0) Console.WriteLine(desetici);
                else if (num >= 20 && b != 0) Console.WriteLine($"{desetici} {edinici}");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
