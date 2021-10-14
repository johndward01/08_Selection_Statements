using System;

namespace Selection_Statements_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //The single if statement
            //bool condition1 = true;

            //if (!condition1)
            //{
            //    Console.WriteLine("The variable is set to true.");
            //    Console.WriteLine();

            //}
            //else
            //{
            //     Console.WriteLine("Another statement");                
            //}


            //Console.WriteLine("If there is nothing above this sentence then the condition was false and that code didn't run.");

            //The if/else statement


            //if (condition2 != 1)
            //{
            //    Console.WriteLine("This variable is equal to 1.");
            //}
            //else
            //{
            //    Console.WriteLine("This variable is not equal to 1.");
            //}

            //The if/else if/else statement
            //int condition2 = 1;

            //switch (condition2)
            //{
            //    case 0:
            //        Console.WriteLine("The variable is 0.");
            //        break;
            //    case 1:
            //        Console.WriteLine("The variable is 1.");
            //        break;
            //    case 2:
            //        Console.WriteLine("The variable is 2.");
            //        break;
            //    case 3:
            //        Console.WriteLine("The variable is 3.");
            //        break;
            //    default:
            //        Console.WriteLine("Tired of writing more cases.");
            //        break;
            //}

            //if (condition2 < 0)
            //{
            //    Console.WriteLine("The variable is negative.");
            //}
            //else if (condition2 > 0)
            //{
            //    Console.WriteLine("The variable is positive.");
            //}
            //else if (!(condition2 == 0))
            //{
            //    Console.WriteLine("Some nonsense");
            //}
            //else
            //{
            //    Console.WriteLine("The variable is 0.");
            //}


            //bool condition1 = true;

            //switch (condition1)
            //{
            //    case true:
            //        Console.WriteLine("True");
            //        break;
            //    case false:
            //        Console.WriteLine("False");
            //        break;
            //    default:
            //        Console.WriteLine("Neither true or false (this will never run!)");
            //        break;
            //}

            //int votingAge;
            //bool isCitizen;
            //string record;

            //Console.WriteLine("How old are you?");
            //votingAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("Are you a legal US citizen?");
            //Console.Write("Type true or false: ");
            //isCitizen = bool.Parse(Console.ReadLine());

            //Console.WriteLine("Do you have a clean record?");
            //Console.Write("Type Y / N : ");
            //record = Console.ReadLine().ToLower();

            //if (votingAge >= 18 && isCitizen && record == "y")
            //{
            //    Console.WriteLine("Can vote in National & State Election");
            //}
            //else if ( record == "y" || votingAge >= 18 && isCitizen)
            //{
            //    Console.WriteLine("You can vote National Election but not the state"); // fix logic 
            //}
            //else
            //{
            //    Console.WriteLine("Sorry! You are not old enough to vote!");
            //}

            //Console.WriteLine("What day of the week is it?");
            //Console.WriteLine("Please enter 0 for Sunday, 1 for Monday, 2 for Tuesday, etc...");
            //int day = int.Parse(Console.ReadLine());

            //string something = "";


            //switch (something)
            //{
            //    case "dkfjdkfjkd":
            //        Console.WriteLine("if");
            //        break;
            //    case temp:
            //        Console.WriteLine("else if");
            //    default:
            //        Console.WriteLine("else");
            //        break;
            //}



            //Console.WriteLine("Enter a day of the week");
            //var day = Console.ReadLine().ToLower();

            //switch (day)
            //{
            //    case "sunday":
            //        Console.WriteLine("Sunday");
            //        break;
            //    case "monday":
            //        Console.WriteLine("Monday");
            //        break;
            //    case "tuesday":
            //        Console.WriteLine("Tuesday");
            //        break;
            //    case "wednesday":
            //        Console.WriteLine("Wednesday");
            //        break;
            //    case "thursday":
            //        Console.WriteLine("Thursday");
            //        break;
            //    case "friday":
            //        Console.WriteLine("Friday");
            //        break;
            //    case "saturday":
            //        Console.WriteLine("Saturday");
            //        break;
            //    case "":
            //        Console.WriteLine("An empty string");
            //        break;
            //    case " ":
            //        Console.WriteLine("An empty space");
            //        break;
            //    default:
            //        Console.WriteLine("Not a day of the week");
            //        break;
            //}


            //int numInt;
            //double numDouble;
            //bool conditional = true;

            //while (conditional)
            //{
            //    Console.WriteLine("Please enter a number and i'll tell you whether it's even or odd");
            //    var userInput = Console.ReadLine();  
            //
            //    if (int.TryParse(userInput, out numInt))
            //    {
            //        if (numInt % 2 == 0)
            //        {
            //            Console.WriteLine("This is an even number");
            //            conditional = false;

            //        }
            //        else
            //        {
            //            Console.WriteLine("This is an odd number");
            //            conditional = false;

            //        }
            //    }
            //    else if (double.TryParse(userInput, out numDouble))
            //    {
            //        if (numDouble % 2 == 0)
            //        {
            //            Console.WriteLine("This is an even number");
            //            conditional = false;

            //        }
            //        else
            //        {
            //            Console.WriteLine("This is an odd number");
            //            conditional = false;

            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a valid number");
            //    }
            //}

            //The exact same example as above, however, we replace the variable "conditional" with true
            //and we use a break statement to exit the while loop (we also change the variable names slightly

            //int numInt1;
            //double numDouble1;

            //while (true)
            //{
            //    Console.WriteLine("Please enter a number and i'll tell you whether it's even or odd");
            //    var userInput1 = Console.ReadLine();
            //    Console.WriteLine();

            //    if (int.TryParse(userInput1, out numInt1))
            //    {
            //        if (numInt1 % 2 == 0)
            //        {
            //            Console.WriteLine("This is an even number");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("This is an odd number");
            //            break;
            //        }
            //    }
            //    else if (double.TryParse(userInput1, out numDouble1))
            //    {
            //        if (numDouble1 % 2 == 0)
            //        {
            //            Console.WriteLine("This is an even number");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("This is an odd number");
            //            break;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("THIS IS NOT A VALID NUMBER!");
            //        Console.WriteLine("Please enter a valid number");
            //        Console.WriteLine();
            //    }
            //}



            var r = new Random();
            var favNumber = r.Next(1, 1000);

            var userInput = Convert.ToInt32(Console.ReadLine());

















        }
    }
}
