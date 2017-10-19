namespace p05___BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookLibrary
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());

            var library = new List<Books>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                var bookInput = Console.ReadLine().Split();

                var BookInfo = new Books
                {
                    Title = bookInput[0],
                    Author = bookInput[1],
                    Publisher = bookInput[2],
                    ReleaseDate = bookInput[3],
                    ISBNNumber = int.Parse(bookInput[4]),
                    Price = double.Parse(bookInput[5])
                };

                library.Add(BookInfo);
            }

            var authors = new Dictionary<string, double>();

            foreach (var book in library)
            {
                if (!authors.ContainsKey(book.Author))
                {
                    authors[book.Author] = 0;
                }
                authors[book.Author] += book.Price;
            }

            var result = authors.
                OrderByDescending(x => x.Value).
                ThenBy(x => x.Key);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
