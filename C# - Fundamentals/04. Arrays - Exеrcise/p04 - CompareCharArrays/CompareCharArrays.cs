namespace p04___CompareCharArrays
{
    using System;
    using System.Linq;

    public class CompareCharArrays
    {
        public static void Main()
        {
            char[] firstArray = Console.ReadLine().Split().Select(char.Parse).ToArray();
            char[] secondArray = Console.ReadLine().Split().Select(char.Parse).ToArray();

            int minLenght = Math.Min(firstArray.Length, secondArray.Length);

            bool areEqual = false;

            for (int i = 0; i < minLenght; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    continue;
                }
                else
                {
                    if (firstArray[i] < secondArray[i])
                    {
                        Console.WriteLine(firstArray);
                        Console.WriteLine(secondArray);
                    }
                    else
                    {
                        Console.WriteLine(secondArray);
                        Console.WriteLine(firstArray);
                    }
                    areEqual = true;
                    break;
                }
            }
            if (!areEqual)
            {
                if (firstArray.Length <= secondArray.Length)
                {
                    Console.WriteLine(firstArray);
                    Console.WriteLine(secondArray);
                }
                else
                {
                    Console.WriteLine(secondArray);
                    Console.WriteLine(firstArray);
                }
            }
        }
    }
}
