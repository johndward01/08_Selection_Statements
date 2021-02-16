using System;

namespace Selection_Statements_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //The single if statement
            bool condition1 = true;

            if (condition1)
            {
                Console.WriteLine("The variable is set to true.");
                Console.WriteLine();
            }
            Console.WriteLine("If there is nothing above this sentence then the condition was false and that code didn't run.");

            ////The if/else statement
            //int condition2 = 1;

            //if (condition2 == 1)
            //{
            //    Console.WriteLine("This variable is equal to 1.");
            //}
            //else
            //{
            //    Console.WriteLine("This variable is not equal to 1.");
            //}

            ////The if/else-if/else statement

            //if (condition2 < 0)
            //{
            //    Console.WriteLine("The variable is set negative.");
            //}
            //else if (condition2 > 0)
            //{
            //    Console.WriteLine("The variable is positive.");
            //}
            //else
            //{
            //    Console.WriteLine("The variable is 0.");
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
        }
    }
}
