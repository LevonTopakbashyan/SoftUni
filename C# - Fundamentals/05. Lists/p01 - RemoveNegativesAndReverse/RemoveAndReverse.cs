namespace p01___RemoveNegativesAndReverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveAndReverse
    {
        public static void Main()
        {
            var listOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var resultList = new List<int>();

            for (int i = 0; i < listOfNumbers.Count; i++)
            {
                if (listOfNumbers[i] >= 0)
                {
                    resultList.Add(listOfNumbers[i]);
                }
            }
            resultList.Reverse();

            if (resultList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(" ",resultList));
            }

        }
    }
}
