namespace p03___MinerTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MinerTask
    {
        public static void Main()
        {
            var resources = new Dictionary<string, int>();

            var line = Console.ReadLine();

            while (line != "stop")
            {
                var resource = line;
                var quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resource))
                {
                    resources[resource] = 0;
                }
                resources[resource] += quantity;

                line = Console.ReadLine();
            }

            foreach (var item in resources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
