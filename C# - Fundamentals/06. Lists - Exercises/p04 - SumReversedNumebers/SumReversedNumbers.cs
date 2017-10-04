namespace p04___SumReversedNumebers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SumReversedNumbers
    {
        public static void Main()
        {
            string[] numbers = Console.ReadLine().Split();

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                string currentNumber = numbers[i];
                List<char> reversedNumber = currentNumber.Reverse().ToList();
                string changedToString = string.Join("", reversedNumber);
                int parsedNumber = int.Parse(changedToString);
                sum += parsedNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
