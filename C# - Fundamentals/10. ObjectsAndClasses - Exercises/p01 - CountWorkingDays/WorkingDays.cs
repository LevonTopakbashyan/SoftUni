namespace p01___CountWorkingDays
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class WorkingDays
    {
        public static void Main()
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(),
                "dd-MM- yyyy",
                null);
            var endDate = DateTime.ParseExact(Console.ReadLine(),
                "dd-MM- yyyy",
                null);

            int workingDaysCounter = 0;

            var listOfHolidays = new List<DateTime>()
            {
                DateTime.Parse("01-01-1970"),
                DateTime.Parse("03-03-1970"),
                DateTime.Parse("01-05-1970"),
                DateTime.Parse("06-05-1970"),
                DateTime.Parse("24-05-1970"),
                DateTime.Parse("06-09-1970"),
                DateTime.Parse("22-09-1970"),
                DateTime.Parse("01-11-1970"),
                DateTime.Parse("24-12-1970"),
                DateTime.Parse("25-12-1970"),
                DateTime.Parse("26-12-1970"),
            };

            for (DateTime currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                DateTime checkDate = new DateTime(1970, currentDate.Month, currentDate.Day);

                if (currentDate.DayOfWeek != DayOfWeek.Saturday &&
                    currentDate.DayOfWeek != DayOfWeek.Sunday &&
                    !listOfHolidays.Contains(checkDate))
                {
                    workingDaysCounter++;
                }
            }

            Console.WriteLine(workingDaysCounter);
        }
    }
}
