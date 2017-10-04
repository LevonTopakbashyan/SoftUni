namespace p07___ExctractMiddleNumber
{
    using System;
    using System.Linq;

    public class MiddleNumber
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (n == 1)
            {
                Console.WriteLine("{" + $"{numbers[0]}" + "}");
            }
            else if (n % 2 == 0)
            {
                Console.WriteLine(numbers[n / 2 - 1]);
                Console.WriteLine(numbers[n / 2]);
            }
            else
            {
                Console.WriteLine(numbers[n / 2 - 1]);
                Console.WriteLine(numbers[n / 2]);
                Console.WriteLine(numbers[n / 2 + 1]);
            }
        }
    }
}
