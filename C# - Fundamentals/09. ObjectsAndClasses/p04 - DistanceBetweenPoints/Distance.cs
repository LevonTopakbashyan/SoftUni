namespace p04___DistanceBetweenPoints
{
    using System;

    public class Distance
    {
        public static void Main()
        {
            var firstPointParts = Console.ReadLine().Split();
            var secondPointParts = Console.ReadLine().Split();

            var firstPoint = new Point
            {
                X = double.Parse(firstPointParts[0]),
                Y = double.Parse(firstPointParts[1])
            };
            
            var secondPoint = new Point
            {
                X = double.Parse(secondPointParts[0]),
                Y = double.Parse(secondPointParts[1])
            };

            var result = CalculateDistance(firstPoint,secondPoint);

            Console.WriteLine($"{result:F3}");
        }

        private static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var diffX = firstPoint.X - secondPoint.X;
            var diffY = firstPoint.Y - secondPoint.Y;

            var powDiffX = Math.Pow(diffX, 2);
            var powDiffY = Math.Pow(diffY, 2);

            return Math.Sqrt(powDiffX + powDiffY);
        }
    }
}
