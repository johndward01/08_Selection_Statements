using System;

namespace Selection_Statements_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1: (if, else-if)

            var r = new Random();

            int favoriteNumber = r.Next(1, 1000);

            Console.Write("Try to guess my favorite number: ");
            var guess = int.Parse(Console.ReadLine());

            if (guess < favoriteNumber)
            {
                Console.WriteLine("too low");
            }
            else if (guess > favoriteNumber)
            {
                Console.WriteLine("too high");
            }
            else
            {
                Console.WriteLine("You got it!");
            }

            

            //Part 2: (Switch/Case)

            Console.WriteLine("Enter your favorite subject in school: ");
            var subject = Console.ReadLine();
            
            switch (subject.ToLower())
            {
                case "pe":
                    Console.WriteLine("Your favorite subject is pe.");
                    break;
                case "history":
                    Console.WriteLine("Your favorite subject is history.");
                    break;
                case "math":
                    Console.WriteLine("Your favorite subject is math.");
                    break;
                case "reading":
                    Console.WriteLine("Your favorite subject is reading.");
                    break;
                case "science":
                    Console.WriteLine("Your favorite subject is science.");
                    break;
                default:
                    Console.WriteLine($"This isn't a subject on the list. " +
                                      $"I'm sure that doesn't make it less important...");
                    break;
            }
            

        }
    }
}
