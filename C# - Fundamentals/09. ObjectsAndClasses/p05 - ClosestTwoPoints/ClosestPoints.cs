namespace p05___ClosestTwoPoints
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ClosestPoints
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            var points = new List<Points>();

            for (int i = 0; i < n; i++)
            {
                var currentPoint = Console.ReadLine().
                    Split().
                    Select(double.Parse).
                    ToArray();

                points.Add(new Points
                {
                    X = currentPoint[0],
                    Y = currentPoint[1]

                });
            }

            var minDistanceSoFar = double.MaxValue;
            Points firstPointMin = null;
            Points secondPointMin = null;

            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    var firstPointParts = points[i];
                    var secondPointParts = points[j];

                    var distance = CalculateDistance(firstPointParts, secondPointParts);

                    if (distance < minDistanceSoFar)
                    {
                        minDistanceSoFar = distance;
                        firstPointMin = firstPointParts;
                        secondPointMin = secondPointParts;
                    }
                }
            }

            Console.WriteLine($"{minDistanceSoFar:F3}");
            Console.WriteLine($"({firstPointMin.X}, {firstPointMin.Y})");
            Console.WriteLine($"({secondPointMin.X}, {secondPointMin.Y})");

        }

        private static double CalculateDistance(Points firstPointParts, Points secondPointParts)
        {
            var diffX = firstPointParts.X - secondPointParts.X;
            var diffY = firstPointParts.Y - secondPointParts.Y;

            var powDiffX = Math.Pow(diffX, 2);
            var powDiffY = Math.Pow(diffY, 2);

            return Math.Sqrt(powDiffX+powDiffY);
        }
    }
}
