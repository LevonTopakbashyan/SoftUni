namespace p03___FoldAndSum
{
    using System;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;

            var firstElements = new int[k];
            var middleElements = new int[k * 2];
            var lastElements = new int[k];

            var resultArray = new int[middleElements.Length];

            for (int i = 0; i < middleElements.Length; i++)
            {
                middleElements[i] = numbers[k + i];
            }
            for (int i = 0; i < k; i++)
            {
                firstElements[i] = numbers[i];
            }

            for (int i = 0; i < k; i++)
            {
                lastElements[i] = numbers[k * 3 + i];
            }

            Array.Reverse(firstElements);
            Array.Reverse(lastElements);

            for (int i = 0; i < middleElements.Length; i++)
            {
                if (i < k)
                {
                    resultArray[i] = firstElements[i] + middleElements[i];
                }
                else
                {
                    resultArray[i] = lastElements[i - k] + middleElements[i];
                }
            }
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
