namespace p02___LongestIncreasingSubsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingSubsequence
    {
        public static void Main()
        {
            Console.Write("Enter the numbers: ");
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var resultList = new List<int>();

            var currenttStart = 0;
            var bestStart = 0;
            var currentLenght = 1;
            var bestLenght = 1;

            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentLenght++;
                }
                else
                {
                    currentLenght = 1;
                    currenttStart = i;
                }
                if (bestLenght < currentLenght)
                {
                    bestLenght = currentLenght;
                    bestStart = currenttStart;
                }
            }
            for (int i = 0; i < bestLenght; i++)
            {
                resultList.Add(numbers[bestStart + i]);
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
