namespace p08___CondenseArrayToNumber
{
    using System;
    using System.Linq;

    public class CondenseArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            /* 
            while (numbers.Length >= 2)
             {
                 var result = new int[numbers.Length - 1];
                 for (int i = 0; i < result.Length; i++)
                 {
                     result[i] = numbers[i] + numbers[i + 1];
                 }
                 numbers = result;
             }
             Console.WriteLine(numbers[0]);
            */

            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = 0; j < numbers.Length-1; j++)
                {
                    numbers[j] = numbers[j] + numbers[j + 1];
                }
            }
            Console.WriteLine(numbers[0]);

        }
    }
}
