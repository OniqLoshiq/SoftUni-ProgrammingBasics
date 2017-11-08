using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___Smart_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            double years = double.Parse(Console.ReadLine());
            double priceWashM = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());

            double toyTotal = 0;
            double moneyBD = 0;
            double yearsBr = 0;
            double totalMoney = 0;


            for (int i = 1; i <= years; i += 2)
            {
                toyTotal += 1.0;
            }
            for (int i = 2; i <= years; i += 2)
            {
                moneyBD += 10.0;
                totalMoney += moneyBD;
                yearsBr += 1.0;
            }

            double Toy = priceToy * toyTotal;
            double money = totalMoney - yearsBr;
            double total = money + Toy;

            if (total >= priceWashM) Console.WriteLine("Yes! {0:f2}", Math.Abs(total - priceWashM));
            else Console.WriteLine("No! {0:f2}", Math.Abs(total - priceWashM));

        }
    }
}
