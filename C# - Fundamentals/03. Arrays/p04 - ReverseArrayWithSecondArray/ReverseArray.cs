namespace p04___ReverseArrayWithSecondArray
{
    using System;
    public class ReverseArray
    {
        public static void Main()
        {
            int numberOfElements = int.Parse(Console.ReadLine());
            var numbers = new int[numberOfElements];
            var reversedArray = new int[numberOfElements];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                reversedArray[numbers.Length - i - 1] = numbers[i];
            }

            foreach (var number in reversedArray)
            {
                Console.WriteLine(number);
            }
        }
    }
}
