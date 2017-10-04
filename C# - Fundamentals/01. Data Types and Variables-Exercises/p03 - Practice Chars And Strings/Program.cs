using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p03___Practice_Chars_And_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            String secondName = Console.ReadLine();

            Console.WriteLine(name);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(secondName);
        }
    }
}
