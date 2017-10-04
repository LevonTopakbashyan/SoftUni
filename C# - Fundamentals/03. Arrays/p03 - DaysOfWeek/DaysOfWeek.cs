namespace p03___DaysOfWeek
{
    using System;
    public class DaysOfWeek
    {
        public static void Main()
        {
            string[] days =
            {
                "Mon",
                "Tue",
                "Wed",
                "Thu",
                "Fri",
                "Sat",
                "Sun"
            };

            int index = int.Parse(Console.ReadLine());

            if (index < 1 || index > 7)
            {
                Console.WriteLine("No such day!");
            }
            else
            {
                Console.WriteLine(days[index-1]);
            }
        }
    }
}
