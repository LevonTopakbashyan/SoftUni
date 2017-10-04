using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p07___Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine(@"Before:
a = {0}
b = {1} ",firstNum,secondNum);
            int tempNum = firstNum;
            firstNum = secondNum;
            secondNum = tempNum;
            Console.WriteLine(@"After:
a = {0}
b = {1} ", firstNum, secondNum);
        }
    }
}
