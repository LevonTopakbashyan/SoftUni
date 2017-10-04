namespace p06___PopulationConter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PopulationCounter
    {
        public static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, double>>();

            var command = Console.ReadLine().Split('|');

            while (command[0] != "report")
            {
                var city = command[0];
                var country = command[1];
                var population = double.Parse(command[2]);

                if (!data.ContainsKey(country))
                {
                    data[country] = new Dictionary<string, double>();
                }
                if (!data[country].ContainsKey(city))
                {
                    data[country].Add(city, population);
                }

                command = Console.ReadLine().Split('|');
            }

            var orderedCountries = data.
                OrderByDescending(x => x.Value.Values.Sum());

            foreach (var item in orderedCountries)
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value.Sum(p => p.Value)})");
                foreach (var city in item.Value.OrderByDescending(c => c.Key))
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
