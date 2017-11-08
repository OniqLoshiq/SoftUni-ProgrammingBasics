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
            string data = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime parsedDate = DateTime.ParseExact(data, format, CultureInfo.InvariantCulture);
            DateTime answer = parsedDate.AddDays(999);
            Console.WriteLine(answer.ToString("dd-MM-yyyy"));




        }
    }
}
