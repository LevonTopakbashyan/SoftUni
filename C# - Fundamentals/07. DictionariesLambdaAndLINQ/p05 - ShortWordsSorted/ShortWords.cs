namespace p05___ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShortWords
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower()
                .Split(new char[] { ' ', '.', ',', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ';', ':' },
                StringSplitOptions.RemoveEmptyEntries).Distinct().Where(w => w.Length < 5).OrderBy(w => w);

            Console.WriteLine(string.Join(", ", text));
        }
    }
}
