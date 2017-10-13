﻿namespace p01___DayOfWeek
{
    using System;
    using System.Globalization;
    
    public class DayOfWeek
    {
        public static void Main()
        {
            var dateAsString = Console.ReadLine();

            var date = DateTime.ParseExact(
                dateAsString,
                "d-M-yyyy",
                CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
        }
    }
}
