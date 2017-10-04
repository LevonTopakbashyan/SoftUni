namespace p02___PhoneBookUpgrade
{
    using System;
    using System.Collections.Generic;

    public class Phonebook
    {
        public static void Main()
        {
            var phoneBook = new SortedDictionary<string, string>();

            var command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "A":
                        phoneBook[command[1]] = command[2];
                        break;
                    case "S":
                        if (phoneBook.ContainsKey(command[1]))
                        {
                            Console.WriteLine($"{command[1]} -> {phoneBook[command[1]]}");
                        }
                        else
                        {
                            Console.WriteLine($"Contact {command[1]} does not exist.");
                        }
                        break;
                    case "ListAll":
                        foreach (var item in phoneBook)
                        {
                            Console.WriteLine($"{item.Key} -> {item.Value}");
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
