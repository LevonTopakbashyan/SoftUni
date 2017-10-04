namespace p07___CountNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CountNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            if (numbers.Count > 0)
            {
                numbers.Sort();
                var previousNumber = numbers[0];
                var count = 1;

                // 2 2 2 2 3 7 8 8
                for (int i = 1; i < numbers.Count; i++)
                {
                    var currentNumber = numbers[i];
                    if (currentNumber == previousNumber)
                    {
                        count++;
                    }
                    else
                    {
                        Console.WriteLine($"{previousNumber} -> {count}");
                        count = 1;
                    }
                    previousNumber = currentNumber;
                }
                Console.WriteLine($"{previousNumber} -> {count}");
            }
        }
    }
}
