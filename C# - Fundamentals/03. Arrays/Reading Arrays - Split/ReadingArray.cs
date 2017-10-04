namespace Reading_Arrays___Split
{
    using System;
    using System.Linq;

    public class ReadingArray
    {
        public static void Main()
        {
            //string text = "1,2,3,4,5";

            //var splitText = text.Split(',').Select(int.Parse).ToArray();

            //var text = "Zdrast, az sum Levo!";

            //  var separator = new char[] { ',', '?', '.', '!', ' ' };

            // var words = text.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            // foreach (var word in words)
            // {
            //      Console.WriteLine(word);
            //  }

            var numbers = new int[] { 1, 2, 3, 4 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"numbers[{i}] = {numbers[i]}");
            }

        }
    }
}
