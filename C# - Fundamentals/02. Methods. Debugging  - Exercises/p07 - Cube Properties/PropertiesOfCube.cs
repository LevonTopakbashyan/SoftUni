namespace p07___Cube_Properties
{
    using System;
    public class PropertiesOfCube
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            Console.WriteLine("{0:f2}",Result(number,type));
        }

        public static double Result(double num, string type)
        {
            double result = 0;
            switch (type)
            {
                case "face": result = Math.Sqrt(num * num * 2);
                    break;
                case "space": result = Math.Sqrt(num * num * 3);
                    break;
                case "volume": result = num * num * num;
                    break;
                case "area": result = num * num;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
