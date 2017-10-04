namespace p09___TripleSum
{
    using System;
    using System.Linq;

    public class TripleSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    int a = numbers[i];
                    int b = numbers[j];
                    int sum = a + b;
                    if (numbers.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                        count++;
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
