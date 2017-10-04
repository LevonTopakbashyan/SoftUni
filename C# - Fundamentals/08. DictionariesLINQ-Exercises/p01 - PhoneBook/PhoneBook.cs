namespace p01___PhoneBook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PhoneBook
    {
        public static void Main()
        {
            var phoneBook = new Dictionary<string, string>();

            var command = Console.ReadLine().Split().ToArray();

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
                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }
        }
    }
}
