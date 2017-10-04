using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    var a = numbers[i];
                    var b = numbers[j];
                    var result = a + b;
                    if (numbers.Contains(result))
                    {
                        Console.WriteLine($"{a} + {b} == {result}");
                        count++;
                    } 
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
