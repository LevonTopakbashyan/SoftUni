namespace p09___Factorial
{
    using System;
    using System.Numerics;
    public class CalculateFactorial
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(number));
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
    }
}
