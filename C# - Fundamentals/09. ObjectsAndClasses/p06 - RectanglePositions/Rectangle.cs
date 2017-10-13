namespace p06___RectanglePositions
{
    public class Rectangle
    {
        public int top { get; set; }

        public int left { get; set; }

        public int width { get; set; }

        public int height { get; set; }

        public int bottom => top - height;

        public int area => height * width;

        public int right => left + width;

    }
}
