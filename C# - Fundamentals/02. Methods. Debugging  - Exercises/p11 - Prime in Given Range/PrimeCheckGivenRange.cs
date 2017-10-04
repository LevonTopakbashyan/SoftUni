namespace p11___Prime_in_Given_Range
{
    using System;
    using System.Collections.Generic;

    public class PrimeCheckGivenRange
    {
        public static void Main()
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());

            var primesInRange = FindPrimesInRange(startNum, endNum);

            Console.WriteLine(string.Join(", ",primesInRange));

        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            var primes = new List<int>();

            for (int currentNum = startNum; currentNum < endNum; currentNum++)
            {
                if (PrimeCheck(currentNum))
                {
                    primes.Add(currentNum);
                }
            }
            return primes;

        }

        public static bool PrimeCheck(long number)
        {
            bool isPrime = true;
            if (number == 2 || number == 3)
            {
                return isPrime;
            }
            else if (number == 0 || number == 1)
            {
                isPrime = false;
                return isPrime;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;
        }
    }
}
