namespace p03___SumAdjacentEqualNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumAdjacent
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(decimal.Parse).ToList();

            while (true)
            {
                bool isEqual = false;

                for (int i = 0; i < numbers.Count-1; i++)
                {
                    decimal first = numbers[i];
                    decimal second = numbers[i + 1];
                    if (first == second)
                    {
                        decimal sum = first + second;
                        numbers.Remove(numbers[i]);
                        numbers.Remove(numbers[i]);
                        numbers.Insert(i, sum);
                        isEqual = true;
                    }
                }
                if (!isEqual)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
