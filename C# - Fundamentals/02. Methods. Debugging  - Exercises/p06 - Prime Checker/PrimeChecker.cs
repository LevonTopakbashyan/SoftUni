namespace p06___Prime_Checker
{
    using System;
    public class PrimeChecker
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(PrimeCheck(number));

        }

        public static string PrimeCheck(long number)
        {
            bool isPrime = true;
            if (number == 2 || number == 3)
            {
                return isPrime.ToString();
            }
            else if (number == 0 || number == 1)
            {
                isPrime = false;
                return isPrime.ToString();
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime.ToString();//.ToLower();
        }
    }
}
