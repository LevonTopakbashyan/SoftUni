namespace NumberOfJumpsRabbit
{
    using System;
    public class JumpsInCircle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int jumps = int.Parse(Console.ReadLine());

            var solution = jumps % n;

            Console.WriteLine(solution);
        }
    }
}
