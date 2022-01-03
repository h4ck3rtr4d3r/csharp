/*
 Using multiple else if statement can get unwieldy pretty quickly. Imagine writing an else if statement for every possible numbner of guests. And you invite 20 people. You have to write a lot of repetitive code, wwhich is hard to read and prone to errors.

 If it's necessary to evaluate several conditions with their own unique output, a switch statement is the way to go. Switch allow for control flow structures by evaluating a single expression and executing code blocks based on a matched case.

 In C#, we wwrite a switch statement using the following syntax:

    string color;

    switch (color)
    {
        case "blue":
            Console.WriteLine("The color is blue");
            break;
        case "red":
            Console.WriteLine("The color is red");
            break;
        case "green":
            Console.WriteLine("The color is green");
            break;
        default:
            Console.WriteLine("The color is not blue, red, or green");
            break;
    }
 
 In this example, the program checks to see what the value of color equals. If it matches any of the specified cases, it will execute the code associated with that case. In C#, the break keyword allows programs to exit a block when a specific condition is met. If none of the conditions are met, the code inside the default case will run.

 When using a switch statement, make sure to pay attention to:
 1- Cases: rather than writing out each condition, if we're evaluating one value we use cases to specify different potential values.
 2- Braces: rather than each case having its own code block, the entire statement lives within one set of braces {}.
 3- Colons: to distinguish between different cases, we state the case value, followed by a colon : . The code that should execute if that case is met follows.
 4- Break: Each case code needs to end with a break keyword.
 5- Default: Every switch statement needs a default case. 
*/

using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            // build a simple movie recommender that gives the top movie in a particular genre. 

            Console.WriteLine("Enter your username.");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter your favorite movie genre.");
            string genre = Console.ReadLine();

            switch (genre)
            {
                case "Drama":
                    Console.WriteLine("The best movie is The Godfather");
                    break;
                case "Comedy":
                    Console.WriteLine("The best movie is The Hangover");
                    break;
                case "Adventure":
                    Console.WriteLine("The best movie is Jumanji");
                    break;
                case "Horror":
                    Console.WriteLine("The best movie is The Exorcist");
                    break;
                case "Science Fiction":
                    Console.WriteLine("The best movie is The Matrix");
                    break;

                default:
                    Console.WriteLine("The best movie is Spider Man");
                    break;
            }
        }
    }
}