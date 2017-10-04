namespace p04___SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByCasing
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '\"'
                , '\'', '\\', '/', '[', ']', ' ' } ,StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            for (int i = 0; i < text.Count; i++)
            {
                bool isLower = false;
                bool isUpper = false;

                if (char.IsLower(text[i]))
                {

                }
            }
        }
    }
}
