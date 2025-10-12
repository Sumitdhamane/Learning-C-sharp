namespace thread
{
    internal class Program
    {
        static void Main()
        {
            // Create and start a new thread
            Thread t1 = new Thread(PrintNumbers);
            t1.Start(); // Starts executing PrintNumbers() in a separate thread

            // Main thread work
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Main Thread: " + i);
                Thread.Sleep(500); // Pause for 0.5 seconds
            }
            t1.IsBackground = true; // Set t1 as a background thread

            //t1.Join(); // Wait for t1 to finish before exiting
            Console.WriteLine("Main thread completed");
        }

        static void PrintNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Worker Thread: " + i);
                Thread.Sleep(300);
            }
        }
    }
}

