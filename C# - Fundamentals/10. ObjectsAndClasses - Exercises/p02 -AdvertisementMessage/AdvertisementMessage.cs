namespace p02__AdvertisementMessage
{
    using System;
    using System.Collections.Generic;

    public class AdvertisementMessage
    {
        public static void Main()
        {

            int numberOfMessages = int.Parse(Console.ReadLine());

            var phrases = new List<string>
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product.",
            };

            var events = new List<string>
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            var authors = new List<string>
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var cities = new List<string>
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            var randomizePhrases = new Random();
            var randomizeEvents = new Random();
            var randomizeAuthors = new Random();
            var randomizeCities = new Random();

            for (int currentMessage = 0; currentMessage < numberOfMessages; currentMessage++)
            {
                var phraseNumber = randomizePhrases.Next(0, phrases.Count);
                var eventNumber = randomizeEvents.Next(0, events.Count);
                var authorNumber = randomizeAuthors.Next(0, authors.Count);
                var cityNumber = randomizeCities.Next(0, cities.Count);

                Console.WriteLine($"{phrases[phraseNumber]} {events[eventNumber]} {authors[authorNumber]} - { cities[cityNumber]} ");

            }


        }
    }
}
