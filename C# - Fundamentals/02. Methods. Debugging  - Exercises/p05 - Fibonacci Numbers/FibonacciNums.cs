namespace p05___Fibonacci_Numbers
{
    using System;
    public class FibonacciNums
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNumbers(number));

        }

        public static int FibonacciNumbers(int number)
        {
            int firstNum = 1;
            int secondNum = 1;
            int newNum = 0;
            if (number == 0 || number == 1)
            {
                return firstNum;
            }
            for (int i = 1; i < number; i++)
            {
                newNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = newNum;
            }

            return secondNum;
        }
    }
}
