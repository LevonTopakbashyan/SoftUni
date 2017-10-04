namespace LastKNumbersSum
{
    using System;

    public class LastKNumbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var numbers = new decimal[n];
            numbers[0] = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                numbers[i] = SumNums(numbers, i - k, i - 1);
            }

            Console.WriteLine("Sequence:");
            Console.WriteLine(string.Join(" ",numbers));
        }

        private static decimal SumNums(decimal[] numbers, int startIndex, int endIndex)
        {
            decimal sum = 0;

            for (int i = startIndex; i <= endIndex; i++)
            {
                if (i >= 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }
    }
}
