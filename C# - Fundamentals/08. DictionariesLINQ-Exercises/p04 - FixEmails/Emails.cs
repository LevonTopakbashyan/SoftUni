namespace p04___FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Emails
    {
        public static void Main()
        {
            var emailAddresses = new Dictionary<string, string>();

            var line = Console.ReadLine();

            while (line != "stop")
            {
                var name = line;
                string email = Console.ReadLine();

                emailAddresses[name] = email;

                line = Console.ReadLine();
            }

            var fixedEmails = emailAddresses.
                Where(a => !a.Value.ToLower().EndsWith("us") && !a.Value.ToLower().EndsWith("us"));

            foreach (var item in fixedEmails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
