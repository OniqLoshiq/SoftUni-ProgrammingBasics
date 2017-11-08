using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Operations_between_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            int plusResult = num1 + num2;
            int minusResult = num1 - num2;
            int multiplicationResult = num1 * num2;



            if (op == "+" && (plusResult % 2 == 0)) Console.WriteLine($"{num1} {op} {num2} = {plusResult} - even");
            else if (op == "+" && (plusResult % 2 != 0)) Console.WriteLine($"{num1} {op} {num2} = {plusResult} - odd");
            else if (op == "-" && (minusResult % 2 == 0)) Console.WriteLine($"{num1} {op} {num2} = {minusResult} - even");
            else if (op == "-" && (minusResult % 2 != 0)) Console.WriteLine($"{num1} {op} {num2} = {minusResult} - odd");
            else if (op == "*" && (multiplicationResult % 2 == 0)) Console.WriteLine($"{num1} {op} {num2} = {multiplicationResult} - even");
            else if (op == "*" && (multiplicationResult % 2 != 0)) Console.WriteLine($"{num1} {op} {num2} = {multiplicationResult} - odd");
            else if (op == "/" && num2 != 0) Console.WriteLine($"{num1} {op} {num2} = {((double)num1 / num2):f2}");
            else if (op == "/" && num2 == 0) Console.WriteLine($"Cannot divide {num1} by zero");
            else if (op == "%" && num2 != 0) Console.WriteLine($"{num1} {op} {num2} = {num1 % num2}");
            else if (op == "%" && num2 == 0) Console.WriteLine($"Cannot divide {num1} by zero");

        }
    }
}
