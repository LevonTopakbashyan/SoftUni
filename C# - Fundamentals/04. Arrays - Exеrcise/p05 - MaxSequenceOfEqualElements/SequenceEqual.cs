namespace p05___MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class SequenceEqual
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int currentStart = 0;
            int currnetLenght = 1;
            int maxLenght = 1;
            int maxStart = 0;

            for (int position = 1; position < numbers.Length; position++)
            {
                if (numbers[position] == numbers[currentStart])
                {
                    currnetLenght++;
                    if (currnetLenght > maxLenght)
                    {
                        maxLenght = currnetLenght;
                        maxStart = currentStart;
                    }
                }
                else
                {
                    currentStart = position;
                    currnetLenght = 1;
                }
            }

            var resultArray = new int[maxLenght];

            for (int position = 0; position < maxLenght; position++)
            {
                resultArray[position] = numbers[maxStart + position];
            }
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
