namespace p10___SumArrays
{
    using System;
    using System.Linq;

    public class SumArrays
    {
        public static void Main()
        {
            var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var lenght = Math.Max(firstArray.Length, secondArray.Length);

            var result = new int[lenght];

            for (int i = 0; i < lenght; i++)
            {
                result[i] = firstArray[i % firstArray.Length] + 
                    secondArray[i%secondArray.Length];
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
