namespace p03___SumMinMaxAverage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumMinMaxAverage
    {
        public static void Main()
        {
            var numberOfElements = int.Parse(Console.ReadLine());

            var numbers = new int[numberOfElements];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Sum = {numbers.Sum()}");
            Console.WriteLine($"Min = {numbers.Min()}");
            Console.WriteLine($"Max = {numbers.Max()}");
            Console.WriteLine($"Average = {numbers.Average()}");
        }
    }
}
