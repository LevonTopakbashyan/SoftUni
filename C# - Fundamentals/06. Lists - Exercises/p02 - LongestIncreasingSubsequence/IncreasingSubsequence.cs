namespace p02___LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingSubsequence
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bombNumber = input[0];
            var bombRange = input[1];


            for (int currentIndex = 0; currentIndex < numbers.Count; currentIndex++)
            {
                if (numbers[currentIndex] == bombNumber)
                {
                    int left = Math.Max(0, currentIndex - bombRange);
                    int right = Math.Min(numbers.Count - 1, currentIndex + bombRange);
                    numbers.RemoveRange(currentIndex, right - currentIndex);
                    numbers.RemoveAt(currentIndex);
                    numbers.RemoveRange(left, currentIndex - left);
                    currentIndex = 0;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
