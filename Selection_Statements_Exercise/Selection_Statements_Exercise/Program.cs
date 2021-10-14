using System;

namespace Selection_Statements_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1: (if, else-if)
            int myInt = 10;

            if (myInt > 10 && "Hey" == "Hey") { Console.WriteLine("This code"); }

            //Random r = new Random();

            //int favoriteNumber = 100;

            //Console.WriteLine("Welcome to the number guessing game!");
            //Console.WriteLine();
            //Console.Write("Please enter a number between 1 - 1000: ");
            //var guess = Convert.ToInt32(Console.ReadLine());

            //if (guess < favoriteNumber)
            //{
            //    Console.WriteLine("too low");
            //}
            //else if (guess > favoriteNumber)
            //{
            //    Console.WriteLine("too high");
            //}
            //else
            //{
            //    Console.WriteLine("You got it!");
            //}



            //Part 2: (Switch/Case)
            Console.WriteLine("Please choose from the following subjects: PE, History, Math, Reading, and Science.");

            Console.Write("Enter your favorite subject in school: ");
            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "pe":
                case "physical education":
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
                    Console.WriteLine($"This isn't a subject on the list. (Check your spelling and try again) ");
                    break;
            }


        }
    }
}
