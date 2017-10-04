namespace p10___EqualSums
{
    using System;
    using System.Linq;

    public class EqualSums
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int index = 0;
            int sumLeft = 0;
            int sumRight = 0;

            bool areEqual = false;

            for (int position = 0; position < numbers.Length; position++)
            {
                sumLeft = 0;
                sumRight = 0;
                for (int rightPositions = position + 1; rightPositions < numbers.Length; rightPositions++)
                {
                        sumRight += numbers[rightPositions];
                }

                for (int leftPositions = 0; leftPositions < position; leftPositions++)
                {
                    sumLeft += numbers[leftPositions];
                }
                if (sumRight == sumLeft)
                {
                    index = position;
                    areEqual = true;
                }
            }
            if (!areEqual)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(index);
            }
        }
    }
}
