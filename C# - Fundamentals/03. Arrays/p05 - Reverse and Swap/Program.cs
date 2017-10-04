namespace p05___Reverse_and_Swap
{
    using System;
    public class Program
    {
        public static void Main()
        {
            var number = new int[] { 5, 2, 3, 4, 1 };

            for (int i = 0; i < number.Length / 2; i++)
            {
                var reversedIndex = number.Length - i - 1;
                var temp = number[i];
                number[i] = number[reversedIndex];
                number[reversedIndex] = temp;
            }

            Console.WriteLine(string.Join(" ",number));
        }
    }
}
