namespace p07___SerbianUnleashed
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Serbian
    {
        public static void Main()
        {
            var data = new Dictionary<string, Dictionary<string, int>>();

            var line = Console.ReadLine().Split();

            while (line[0] != "End")
            {
                var singer = line[0];
                var venue = "@" + line[1];
                var ticketPrices = int.Parse(line[2]);
                var ticketsCount = int.Parse(line[3]);

                var totalMoney = ticketPrices * ticketsCount;

                if (!data.ContainsKey(venue))
                {
                    data[venue] = new Dictionary<string, int>();
                }
                if (!data[venue].ContainsKey(singer))
                {
                    data[venue].Add(singer, totalMoney);
                }
                else
                {
                    data[venue][singer] += totalMoney;
                }

                line = Console.ReadLine().Split();
            }
            
            foreach (var item in data)
            {
                Console.WriteLine(item.Key);
                foreach (var singer in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }
        }
    }
}
