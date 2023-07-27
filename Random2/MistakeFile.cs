using System;
//This is the Merge Conflict
namespace RandomNameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = { "Paige", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Henry", "Isabelle", "Jack", "Kate", "Luke", "Mia", "Noah", "Olivia", "Peter", "Quinn", "Rose", "Sam", "Tara", "Uma", "Violet", "Will", "Xander", "Yara", "Zane" };
            string[] lastNames = { "Smith", "Johnson", "Brown", "Lee", "Wilson", "Davis", "Miller", "Wilson", "Walker", "Clark", "Lewis", "Taylor", "Hall", "Harris", "Martin", "White", "Green", "Adams", "Allen", "Baker", "Carter", "Evans", "Garcia", "Hayes", "Hill", "King" };

            Random random = new Random();
            string firstName = firstNames[random.Next(firstNames.Length)];
            string lastName = lastNames[random.Next(lastNames.Length)];

            Console.WriteLine($"Random Name: {firstName} {lastName}");
        }
    }
}