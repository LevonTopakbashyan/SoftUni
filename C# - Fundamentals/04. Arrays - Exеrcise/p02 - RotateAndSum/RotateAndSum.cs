namespace p02___RotateAndSum
{
    using System;
    using System.Linq;

    public class RotateAndSum
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            var sumOfRotations = new int[numbers.Length];

            for (int currentIndex = 0; currentIndex < rotations; currentIndex++)
            {
                int lastElement = numbers[numbers.Length - 1];

                for (int currentElement = numbers.Length - 1; currentElement > 0; currentElement--)
                {
                    numbers[currentElement] = numbers[currentElement - 1];
                }

                numbers[0] = lastElement;

                for (int currentElement = 0; currentElement < numbers.Length; currentElement++)
                {
                    sumOfRotations[currentElement] += numbers[currentElement];
                }
            }
            Console.WriteLine(string.Join(" ",sumOfRotations));
        }
    }
}
