namespace p01___Hello__Name_
{
    using System;
    public class HelloName
    {
        public static void Main() {
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }

        public static string Name(string name) {
            return name;
        }
    }
}
