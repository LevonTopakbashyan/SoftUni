namespace p08___Geometry_Calculator
{
    using System;
    public class CalculateAreas
    {
        public static void Main()
        {
            string type = Console.ReadLine();
            Console.WriteLine($"{Area(type):f2}");
        }

        public static double Area(string type)
        {
            double area = 0;
            switch (type)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    area = side * height / 2;
                    break;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    area = sideSquare * sideSquare;
                    break;
                case "rectangle":
                    double width = double.Parse(Console.ReadLine());
                    double heightRectangle = double.Parse(Console.ReadLine());
                    area = width * heightRectangle;
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    area = Math.PI * radius * radius;
                    break;
                default:
                    break;
            }
            return area;
        }
    }
}
