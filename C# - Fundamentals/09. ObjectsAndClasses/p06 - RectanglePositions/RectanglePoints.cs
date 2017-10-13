namespace p06___RectanglePositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RectanglePoints
    {
        public static void Main()
        {
            var firstRectangleParts = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var secondRectangleParts = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var firstRectangle = new Rectangle
            {
                left = firstRectangleParts[0],
                top = firstRectangleParts[1],
                width = firstRectangleParts[2],
                height = firstRectangleParts[3]
            };

            var secondRectangle = new Rectangle
            {
                left = secondRectangleParts[0],
                top = secondRectangleParts[1],
                width = secondRectangleParts[2],
                height = secondRectangleParts[3]
            };

            bool inside = isInside(firstRectangle, secondRectangle);

            if (inside)
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not Inside");
            }

        }

        public static bool isInside(
            Rectangle first,
            Rectangle second)
        {
            var leftIsCorrect = first.left >= second.left;
            var rightIsCorrect = first.right <= second.right;
            var topIsCorrect = first.top <= second.top;
            var bottomIsCorrect = first.bottom >= second.bottom;

            return leftIsCorrect &&
                rightIsCorrect &&
                topIsCorrect &&
                bottomIsCorrect;
        }
    }
}
