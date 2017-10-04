using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04___Variable_in_Hexadecimal_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = Console.ReadLine();
            int fromBase = 16;
            int number = Convert.ToInt32(value, fromBase);
            Console.WriteLine(number);
        }
    }
}
