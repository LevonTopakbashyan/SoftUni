namespace p07___SalesReport
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class SalesReport
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var sales = new List<Sales>();

            for (int i = 0; i < n; i++)
            {
                var currentSaleParts = Console.ReadLine().Split();

                var currentSale = new Sales
                {
                    Town = currentSaleParts[0],
                    Product = currentSaleParts[1],
                    Price = double.Parse(currentSaleParts[2]),
                    Quantity = double.Parse(currentSaleParts[3])
                };

                sales.Add(currentSale);
            }

            var result = new SortedDictionary<string, double>();

            foreach (var sale in sales)
            {
                if (!result.ContainsKey(sale.Town))
                {
                    result[sale.Town] = 0;
                }
                result[sale.Town] += sale.Price * sale.Quantity;
            }

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:F2}");
            }
        }
    }
}
