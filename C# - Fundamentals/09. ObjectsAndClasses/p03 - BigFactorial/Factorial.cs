namespace p03___BigFactorial
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Factorial
    {
        public static void Main()
        {
            var factorialNumber = int.Parse(Console.ReadLine());
            BigInteger sum = 1;
            BigInteger result = SumFactorial(factorialNumber,sum);

            Console.WriteLine(result); 
        }

        private static BigInteger SumFactorial(int factorialNumber,BigInteger sum)
        {
            if (factorialNumber <= 0)
            {
                return sum;
            }
            else
            {
                sum *= factorialNumber;
            }
            return SumFactorial(factorialNumber - 1,sum);
        }
    }
}
