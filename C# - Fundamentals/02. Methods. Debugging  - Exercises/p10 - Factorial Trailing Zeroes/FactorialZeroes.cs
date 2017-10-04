namespace p10___Factorial_Trailing_Zeroes
{
    using System;
    using System.Numerics;
    public class FactorialZeroes
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Zeroes(number));

        }

        public static BigInteger Factorial(int num)
        {
            BigInteger result = 1;
            for (int i = num; i >= 1; i--)
            {
                result *= i;
            }
            return result;
        }

        public static BigInteger Zeroes(int num)
        {
            BigInteger result = Factorial(num);
            BigInteger zeroCounter = 0;
            BigInteger digit;
            if(result % 10 == 0  && result / 10 % 10 != 0)
            {
                zeroCounter++;
            }
            while (result > 0)
            {
                digit = result % 10;
                if (digit == 0 && result / 10 % 10 == 0)
                {
                    zeroCounter++;
                }
                result /= 10;
            }
            return zeroCounter;
        }
    }
}
