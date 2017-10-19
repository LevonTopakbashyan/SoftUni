using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace p06___BookLibraryModification
{
    public class BookLibraryModification
    {
        public static void Main()
        {
            int numberOfBooks = int.Parse(Console.ReadLine());
            
            var listOfBooks = new List<Books>();

            for (int currentBook = 0; currentBook < numberOfBooks; currentBook++)
            {
                var bookInput = Console.ReadLine().Split();

                var newBook = new Books
                {
                    Title = bookInput[0],
                    Author = bookInput[1],
                    Publisher = bookInput[2],
                    ReleaseDate = DateTime.ParseExact(bookInput[3],"dd-MM-yyyy",CultureInfo.InvariantCulture),
                    ISBNNumber = int.Parse(bookInput[4]),
                    Price = double.Parse(bookInput[5])
                };

                listOfBooks.Add(newBook);
            }
            var date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var library = new Dictionary<string, DateTime>();

            var resultDict = new Dictionary<string, DateTime>();

            foreach (var book in listOfBooks)
            {
                if (!library.ContainsKey(book.Title))
                {
                    library[book.Title] = new DateTime();
                }
                library[book.Title] = book.ReleaseDate;

                if (library[book.Title] >= date)
                {
                    resultDict.Add(book.Title, library[book.Title]);
                }
            }

            var result = resultDict.
                OrderBy(x => x.Value).
                ThenBy(x => x.Key);

            foreach (var item in resultDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
