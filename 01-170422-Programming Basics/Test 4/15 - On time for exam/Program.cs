using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___On_time_for_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrival = int.Parse(Console.ReadLine());
            int minutesArrival = int.Parse(Console.ReadLine());

            int exam = hourExam * 60 + minutesExam;
            int arrival = hourArrival * 60 + minutesArrival;
            int extra = Math.Abs(arrival - exam);
            int extraHour = extra / 60;
            int extraMinutes = extra % 60;

            if (exam == arrival) Console.WriteLine("On time");
            else if (arrival > exam && (extra <= 59))
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{extra} minutes after the start");
            }
            else if (arrival > exam && (extra > 59))
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{extraHour}:{extraMinutes:00} hours after the start");
            }
            else if (arrival < exam && extra > 30 && (extra <= 59))
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{extra} minutes before the start");
            }
            else if (arrival < exam && extra > 30 && (extra > 59))
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{extraHour}:{extraMinutes:00} hours before the start");
            }
            else if (arrival < exam && extra <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{extra} minutes before the start");
            }
        }
    }
}
