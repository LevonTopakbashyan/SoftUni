using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p06___Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            object concat = first + " " + second;
            string result = (string)concat;

            Console.WriteLine(result);
        }
    }
}
