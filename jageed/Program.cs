using System;

namespace CDACMarks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of batches: ");
            int batchCount = int.Parse(Console.ReadLine());

            // Jagged array: each element represents a batch (which has its own array of student marks)
            int[][] marks = new int[batchCount][];

            // Accepting number of students and their marks
            for (int i = 0; i < batchCount; i++)
            {
                Console.Write($"Enter number of students in batch {i + 1}: ");
                int studentCount = int.Parse(Console.ReadLine());

                // Create inner array for each batch
                marks[i] = new int[studentCount];

                // Accept marks for each student
                for (int j = 0; j < studentCount; j++)
                {
                    Console.Write($"Enter marks of student {j + 1} in batch {i + 1}: ");
                    marks[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // Displaying marks batch-wise
            Console.WriteLine("\n=== Displaying Marks Batch-wise ===");
            for (int i = 0; i < batchCount; i++)
            {
                Console.Write($"Batch {i + 1} marks: ");
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.Write(marks[i][j] + " ");
                }
                Console.WriteLine(); // new line after each batch
            }

            Console.ReadLine();
        }
    }
}
