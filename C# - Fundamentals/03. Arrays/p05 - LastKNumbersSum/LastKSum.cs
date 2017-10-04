namespace p05___LastKNumbersSum
{
    using System;

    public class LastKSum
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var numbers = new long[n];
            numbers[0] = 1;

            long sumOfPrevNumbers = 0;

            for (int currentIndex = 1; currentIndex < numbers.Length; currentIndex++)
            {
                for (int prevIndex = 0; prevIndex < k; prevIndex++)
                {
                    if (k > currentIndex)
                    {
                        sumOfPrevNumbers += numbers[prevIndex];
                    }
                    else
                    {
                        sumOfPrevNumbers += numbers[currentIndex - k + prevIndex];
                    }
                }
                numbers[currentIndex] = sumOfPrevNumbers;
                sumOfPrevNumbers = 0;
            }

            Console.WriteLine(string.Join(" ",numbers));

        }
    }
}
    