using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string secondname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstname, secondname, age, town);

            string 1stname = Console.ReadLine();
            string 2ndname = Console.ReadLine();
            int god = int.Parse(Console.ReadLine());
            string grad = Console.ReadLine();
            Console.WriteLine($"You are {1stname} {2ndname}, a {god}-years old person from {grad}.");
        }
    }
}
