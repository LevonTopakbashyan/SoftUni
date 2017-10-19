namespace p07___AndreyAndBilliard
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Billiard
    {
        public static void Main()
        {
            int numberOfEntities = int.Parse(Console.ReadLine());

            var listOfClients = new List<Client>();
            var shop = new Dictionary<string, double>();

            for (int i = 0; i < numberOfEntities; i++)
            {
                var input = Console.ReadLine().Split('-');

                if (!shop.ContainsKey(input[0]))
                {
                    shop[input[0]] = 0;
                }
                shop[input[0]] = double.Parse(input[1]);

            }

            while (true)
            {
                var client = Console.ReadLine().Split('-', ',');

                if (client[0] == "end of clients")
                {
                    break;
                }

                if (shop.ContainsKey(client[1]))
                {
                    var newClient = new Client();
                    newClient.Name = client[0];
                    newClient.Order = new Dictionary<string, int>();
                    newClient.Order.Add(client[1], int.Parse(client[2]));
                    newClient.Bill = shop[client[1]] * int.Parse(client[2]);
                    listOfClients.Add(newClient);
                }
            }
            double sum = 0;

            var ordered = listOfClients.
                OrderBy(x => x.Name).
                ThenBy(x => x.Bill).
                ToList();

            foreach (var customer in ordered)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string,int> item in customer.Order)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:F2}");
                sum += customer.Bill;
            }

            Console.WriteLine($"Total bill: {sum:F2}");
        }
    }
}
