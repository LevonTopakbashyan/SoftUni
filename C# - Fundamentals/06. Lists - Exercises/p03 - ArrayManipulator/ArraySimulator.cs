namespace p03___ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArraySimulator
    {
        public static void Main()
        {
            Console.WriteLine("Enter numbers: ");
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Console.WriteLine("Selec an option.");
            string options = Console.ReadLine();
            if (options == "add")
            {
                Console.WriteLine("Index of the changed number.");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the new number");
                int newNumber = int.Parse(Console.ReadLine());
                Add(index, newNumber, numbers);
                Print(numbers);
            }
            else if (options == "addMany")
            {
                Console.WriteLine("Index of the changed number.");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the new set of number");
                var newSetOfNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                AddMany(index, newSetOfNumbers, numbers);
                Print(numbers);
            }

        }

        private static void AddMany(int index, int[] newSetOfNumbers, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[index])
                {
                    for (int j = i; j < length; j++)
                    {

                    }
                }
            }
        }

        private static void Print(int[] numbers)
        {
            Console.WriteLine(string.Join(" ",numbers));
        }

        private static void Add(int index, int newNumber, int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[index])
                {
                    numbers[i] = newNumber;
                }
            }
        }
    }
}
