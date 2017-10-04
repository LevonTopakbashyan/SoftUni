namespace p01___ReverseArray
{
    using System;
    public class ReverseArray
    {
        public static void Main()
        {
            var numbersOfElements = int.Parse(Console.ReadLine());

            var numbers = new int[numbersOfElements];

            for (int i = 0; i < numbers.Length; i++)
            {
                var currentNumber = int.Parse(Console.ReadLine());
                numbers[i] = currentNumber;
           }

            for (int i = numbers.Length-1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
