namespace ReverseArray
{
    using System;
    using System.Linq;

    public class Reverse
    {
        public static void Main()
        {
            /* 
             var items = Console.ReadLine().Split(' ').ToArray().Reverse();
             Console.WriteLine(string.Join(" ", items));

             var items = Console.ReadLine().Split(' ').ToArray();
             var result = new string[items.Length];
             for (int i = 0; i < items.Length; i++)
             {
                 result[items.Length - i - 1] = items[i];
             }
             Console.WriteLine(string.Join(" ", result));
            */

            var items = Console.ReadLine().Split(' ').ToArray();         
                Swap(items, items.Length - 1);
        }

        private static void Swap(string[] items, int lenght)
        {
            for (int i = 0; i < lenght/2; i++)
            {

                var oldValue = items[i];
                items[i] = items[lenght - i];
                items[lenght - i] = oldValue;
            }
            Console.WriteLine(string.Join(" ",items));
        }
    }
}
