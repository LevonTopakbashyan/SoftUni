namespace p03___IntersectionOfCircle
{
    using System;
    using System.Linq;

    public class IntersectionOfCircle
    {
        public static void Main()
        {
            var firstCircleInput = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondCircleInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstCenter = new Point
            {
                X = firstCircleInput[0],
                Y = firstCircleInput[1]
            };

            var secondCenter = new Point
            {
                X = secondCircleInput[0],
                Y = secondCircleInput[1]
            };

            var firstCircle = new Circle
            {
                Center = firstCenter,
                Radius = firstCircleInput[2]
            };

            var secondCircle = new Circle
            {
                Center = secondCenter,
                Radius = secondCircleInput[2]
            };

            var isIntersect = Intersect(firstCircle, secondCircle);

            if (isIntersect)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        private static bool Intersect(Circle firstCircle, Circle secondCircle)
        {
            int d = CalculateDistance(firstCircle.Center, secondCircle.Center);

            if (d <= firstCircle.Radius + secondCircle.Radius)
            {
                return true;
            }
            return false;
        }

        private static int CalculateDistance(Point firstCenter, Point secondCenter)
        {
            int diffX = firstCenter.X - secondCenter.X;
            int diffY = firstCenter.Y - secondCenter.Y;
            var powDiffX = Math.Pow(diffX, 2);
            var powDiffY = Math.Pow(diffY, 2);

            return (int)Math.Sqrt(powDiffX + powDiffY);
        }
    }
}
