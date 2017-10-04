using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p14___Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double fisrtNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            double subtrack = Math.Abs(fisrtNum - secondNum);

            if(subtrack < eps){
                Console.WriteLine("True");
            }else if(subtrack >= eps) {
                Console.WriteLine("False");
            }
        }
    }
}
