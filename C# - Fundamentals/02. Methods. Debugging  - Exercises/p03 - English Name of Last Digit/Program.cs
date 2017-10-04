namespace p03___English_Name_of_Last_Digit
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(NameDigit(number));
            int a = 432;
            Console.WriteLine();
        }

        public static string NameDigit(int number)
        {
            int digit = number % 10;
            string name;
            switch (digit)
            {
                case 1: name = "one";
                    return name;
                case 2: name = ("two");
                    return name;
                case 3: name = ("three");
                    return name;
                case 4: name =("four");
                    return name;
                case 5: name =("five");
                    return name;
                case 6: name =("six");
                    return name;
                case 7: name = ("seven");
                    return name;
                case 8: name = ("eight");
                    return name;
                case 9: name = ("nine");
                    return name;
                case 0: name = ("zero");
                    return name;
                default:
                    break;            
            }
            return digit.ToString();              
        }
    }
}
