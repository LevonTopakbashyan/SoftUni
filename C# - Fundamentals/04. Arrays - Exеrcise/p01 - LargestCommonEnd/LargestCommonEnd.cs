namespace p01___LargestCommonEnd
{
    using System;
    using System.Linq;

    public class LargestCommonEnd
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine().Split();
            var secondArray = Console.ReadLine().Split();

            int minLenght = Math.Min(firstArray.Length, secondArray.Length);
            
           int leftCounter = CheckArray(firstArray, secondArray, minLenght);

            Array.Reverse(firstArray);
            Array.Reverse(secondArray);

            int rightCounter = CheckArray(firstArray, secondArray, minLenght);

            Console.WriteLine(Math.Max(leftCounter,rightCounter));
        }

        private static int CheckArray(string[] firstArray, string[] secondArray, int minLenght)
        {
            int counter = 0;
            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }

            return counter;
        }
    }
}
