using System;

namespace ExtensionDemo
{
    // Extension methods must be inside a static class
    public static class IntExtensions
    {
        public static void Display(this int i)
        {
            Console.WriteLine(i);
        }
    }

    internal class Program
    {
        public static void Main(string[] args)
        {
            int i = 100;

            // Now you can call Display() directly on int
            i.Display();  // Output: 100
        }
    }
}
