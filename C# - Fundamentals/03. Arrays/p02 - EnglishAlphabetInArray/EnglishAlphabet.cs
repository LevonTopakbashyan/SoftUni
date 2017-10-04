namespace p02___EnglishAlphabetInArray
{
    using System;

    public class EnglishAlphabet
    {
        public static void Main()
        {
            var alphabet = new char[26];

            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)(i + 97);
                Console.WriteLine(alphabet[i]);
            }
        }
    }
}
