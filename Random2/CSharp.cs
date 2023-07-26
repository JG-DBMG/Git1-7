using System;

namespace RandomCSharpCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Random C# Code Generator!");

            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

            Console.WriteLine("Generated random numbers:");

            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}