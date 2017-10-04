namespace p06___SquareNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SquareNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var resultList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
                {
                    resultList.Add(numbers[i]);
                }
            }
            resultList.Sort();
            resultList.Reverse();

            Console.WriteLine(string.Join(" ",resultList));
        }
    }
}
