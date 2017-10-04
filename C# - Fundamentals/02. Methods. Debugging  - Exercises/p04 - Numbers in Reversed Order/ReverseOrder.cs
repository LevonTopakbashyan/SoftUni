namespace p04___Numbers_in_Reversed_Order
{
    using System;
    public class ReverseOrder
    {
        public static void Main()
        {
            var num = double.Parse(Console.ReadLine());
            Console.WriteLine(ReversedNumber(num));
        }

        private static double ReversedNumber(double num)
        {
            var numString = num.ToString();
            var reversedString = string.Empty;

            for (int i = numString.Length-1; i >= 0; i--)
            {
                reversedString += numString[i];
            }
            var reversedNum = double.Parse(reversedString);
            return reversedNum;
        }
    }
}
