using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());
            
            double timeVanio = meters * speed;
            double timeAdditional = Math.Floor((meters / 15.0)) * 12.5;
            double timeTotal = timeVanio + timeAdditional;

            if(timeTotal >= record) Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", timeTotal - record);
            else Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", timeTotal);
           
        }
    }
}
