using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            int hall = rows * columns;
            double premiere = Math.Round((hall * 12.00), 2);
            double normal = Math.Round((hall * 7.50), 2);
            double discount = Math.Round((hall * 5.00), 2);

            if (type == "premiere") Console.WriteLine(premiere + " leva");
            else if (type == "normal") Console.WriteLine(normal + " leva");
            else if (type == "discount") Console.WriteLine(discount + " leva");
        }
    }
}
