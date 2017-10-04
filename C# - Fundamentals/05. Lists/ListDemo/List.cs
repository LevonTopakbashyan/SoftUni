namespace ListDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class List
    {
        public static void Main()
        {
            var listOfNumbers = new List<int>();

            listOfNumbers.Add(10);
            listOfNumbers.Add(20);
            listOfNumbers.Add(30);


            listOfNumbers.Insert(1, 45);
            listOfNumbers.RemoveAll(x => x % 20 == 0);
            var result = listOfNumbers.Contains(20);

            listOfNumbers.Sort();
            listOfNumbers.Reverse();

            Console.WriteLine(result);
            Console.WriteLine(listOfNumbers.Count);

            foreach (var number in listOfNumbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
