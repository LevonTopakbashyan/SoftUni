namespace p08___IndexOfLetter
{
    using System;
    using System.Linq;

    public class IndexOfLetter
    {
        public static void Main()
        {
            var symbols = Console.ReadLine().ToLower();
            int index = 0;

            for (int i = 0; i < symbols.Length; i++)
            {
                index = symbols[i] - 97;
                Console.WriteLine($"{symbols[i]} -> {index}");
            }
        }
    }
}
