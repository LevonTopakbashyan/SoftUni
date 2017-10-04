namespace p04___Largest3Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LargestNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = numbers.OrderByDescending(n => n).Take(3).ToList();

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
