namespace p06___FoldAndSum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FoldAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var k = numbers.Length / 4;

            var firstRowLeft = numbers.
                Take(k).
                Reverse().
                ToArray();

            var firstRowRight = numbers.
                Reverse().
                Take(k).
                ToArray();

            var firstRow = firstRowLeft.
                Concat(firstRowRight).
                ToArray();

            var secondRow = numbers.
                Skip(k).
                Take(2 * k).
                ToArray();

            var result = new int[secondRow.Length];

            for (int i = 0; i < secondRow.Length; i++)
            {
                result[i] =  firstRow[i] + secondRow[i];
            }

            Console.WriteLine(string.Join(" ",result));
        }
    }
}
