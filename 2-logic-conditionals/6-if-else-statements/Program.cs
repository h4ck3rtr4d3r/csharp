/*
 What if we want another set of instructions to execute if the condition is false? An else clause can be added to an if statement to provide code that will only be executed if the if condition is false.

 In C#, we write an if...else statement using the following syntax:

    string color = "red";
    if (color == "blue")
    {
        Console.WriteLine("The color is blue.");
    }
    else
    {
        Console.WriteLine("The color is not blue.");
    }
 In this example, we're still checking to see if color equals "blue". However, this time ew also added a second code block that will execute if the result of (color == "blue") is false. Since color equals "red" this time, it will skip the first code block and execute the second code block, before moving on with the rest of the program.

 When writing an if...else statement, make sure to pay attention to:
 1 - else follows if: In an if...else statement, the else statement and its corresponding code block still need to follow the if statement and code block.
 2 - Number of code blocks: Make sure that if you include an else statement, that you include a code block with it.
*/

using System;

namespace IfElseStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = 10;
            string weather = "nice";

            if (people <= 10 && weather == "nice")
            {
                Console.WriteLine("SaladMart");
            }
            else
            {
                Console.WriteLine("Soup N Sandwich");
            }
        }
    }
}