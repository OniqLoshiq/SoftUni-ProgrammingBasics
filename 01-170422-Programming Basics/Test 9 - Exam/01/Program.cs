using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int sladkari = int.Parse(Console.ReadLine());
            int torti = int.Parse(Console.ReadLine());
            int gofreti = int.Parse(Console.ReadLine());
            int pala4inki = int.Parse(Console.ReadLine());

            double tortaPrice = 45.0;
            double gofretaPrice = 5.80;
            double pala4inkaPrice = 3.20;

            double tortiTotal = tortaPrice * torti;
            double gofretiTotal = gofretaPrice * gofreti;
            double pala4inkiTotal = pala4inkaPrice * pala4inki;

            double sum = tortiTotal + gofretiTotal + pala4inkiTotal;
            double sumTotal = sum * days * sladkari;
            double sumReal = sumTotal - sumTotal / 8;

            Console.WriteLine("{0:f2}", sumReal);

        }
    }
}
