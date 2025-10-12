namespace presentation
{
    internal class Program
    {
        static void Main()
        {
            int[] numbers = Enumerable.Range(1, 20).ToArray();

            // Normal LINQ
            var result1 = from n in numbers
                          where n % 2 == 0
                          select n * n;

            Console.WriteLine("Sequential LINQ:");
            foreach (var n in result1)
                Console.Write(n + " ");

            Console.WriteLine("\n\nParallel LINQ (PLINQ):");

            // Using PLINQ
            var result2 = numbers
                          .AsParallel()
                          .Where(n => n % 2 == 0)
                          .Select(n => n * n);

            foreach (var n in result2)
                Console.Write(n + " ");
        }
    }
}
