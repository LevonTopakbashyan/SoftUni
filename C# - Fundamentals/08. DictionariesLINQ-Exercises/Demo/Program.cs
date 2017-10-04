using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var emailAddresses = new Dictionary<string, string>();
            var command = Console.ReadLine();

            while (command != "stop")
            {
                var name = command;
                var email = Console.ReadLine();

                emailAddresses[name] = email;

                command = Console.ReadLine();
            }

            var fixedEmails = emailAddresses.
                Where(a => !a.Value.ToLower().EndsWith("us") && !a.Value.ToLower().EndsWith("uk"));

            foreach (var item in fixedEmails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
