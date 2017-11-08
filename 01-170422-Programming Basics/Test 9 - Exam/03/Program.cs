using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string cocktail = Console.ReadLine().ToLower();
            string size = Console.ReadLine().ToLower();
            int drinks = int.Parse(Console.ReadLine());

            double smallCocktail = 0.0;
            double bigCocktail = 0.0;
            double price = 0.0;
            
            if (cocktail == "watermelon")
            {
                smallCocktail = 56.0 * 2;
                bigCocktail = 28.7 * 5;
                double priceCocktail = size == "small" ? smallCocktail : bigCocktail;
                price = drinks * priceCocktail;
            }
            else if (cocktail == "mango")
            {
                smallCocktail = 36.66 * 2;
                bigCocktail = 19.6 * 5;
                double priceCocktail = size == "small" ? smallCocktail : bigCocktail;
                price = drinks * priceCocktail;
            }
            else if (cocktail == "pineapple")
            {
                smallCocktail = 42.1 * 2;
                bigCocktail = 24.8 * 5;
                double priceCocktail = size == "small" ? smallCocktail : bigCocktail;
                price = drinks * priceCocktail;
            }
            else if (cocktail == "raspberry")
            {
                smallCocktail = 20.0 * 2;
                bigCocktail = 15.2 * 5;
                double priceCocktail = size == "small" ? smallCocktail : bigCocktail;
                price = drinks * priceCocktail;
            }
            if (price > 1000) Console.WriteLine("{0:f2} lv.", price * 0.5);
            else if ( price >= 400) Console.WriteLine("{0:f2} lv.", price * 0.85);
            else Console.WriteLine("{0:f2} lv.", price);
        }
    }
}
