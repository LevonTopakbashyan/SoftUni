using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p11___Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());
            double totalHours = hours + (minutes * 0.0166667) + (seconds * 0.000277778);
            double totalMinutes = minutes + (hours * 60) + (seconds * 0.0166667);
            double totalSeconds = seconds + (minutes * 60) + (hours * 3600);

            double MetersPerSecond = (distance) / totalSeconds;
            double kilometersPerHour = (distance * 0.001) / totalHours;
            double milesPerHour = (distance * 0.000621371) / totalHours;

            Console.WriteLine("{0:F6}",MetersPerSecond);
            Console.WriteLine("{0:F6}", kilometersPerHour);
            Console.WriteLine("{0:F6}", milesPerHour);

        }
    }
}
