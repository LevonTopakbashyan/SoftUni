namespace p07__MostFrequentNumer
{
    using System;
    using System.Linq;

    public class FrequentNumber
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int frequent = 0;
            int count = 0;
            int maxCount = 0;

            for (int firstPosition = 0; firstPosition < numbers.Length; firstPosition++)
            {
                for (int secondPosition = 0; secondPosition < numbers.Length; secondPosition++)
                {
                    if (numbers[firstPosition] == numbers[secondPosition])
                    {
                        count++;
                        if (maxCount < count)
                        {
                            maxCount = count;
                            frequent = numbers[secondPosition];
                        }
                    }
                }
                count = 0;
            }

            Console.WriteLine(frequent);

        }
    }
}
