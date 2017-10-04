namespace p02___Max_Method
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(num1, num2, num3));
        }

        public static int GetMax(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                return firstNumber;
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                return secondNumber;
            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                return thirdNumber;
            }
            return firstNumber;
        }
    }
}