/*
 Conditional statements are the most commonly used control structures in programming. They rely on the computer being able to reason whether conditions are true or false.

 The most basic conditional statement is an if statement. An if statement executes a block of code if specific condition is true.

 In C#, e write an if statement using the following syntax:
    
    string color = "blue";
    if (color == "blue")
    {
        Console.WriteLine("The color is blue.");
    }
    else
    {
        Console.WriteLine("The color is not blue.");
    }
 In this example, our if conditional statement checks to see if the value of the variable color is equivalent to the string "blue". Since it is, it will execute the code in the code block and print the string "The color is blue" to the console. If color equals another value or was null, the program skips over the block and moves on to the next instruction.

 When writing an if statement, make sure to pay attention to:
 - Parentheses: we place the boolean expression that the if statement is evaluating in parentheses.
 - Braces: after the boolean expression, we write a set of braces {}. Write the code that will execute if the boolean expression evaluates to true inside these braces.
 - Indentation: while whitespace won't impact our program, it is convention to indent the code inside the braces by to spaces.
*/

using System;
namespace IfStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int socks = 3;
            /*
            You take your laundry to the laundromat once you have exactly three pairs of socks or less left. Write an if statement to check whether or not it’s time to take your laundry in. Leave the code block empty for now.
            */
            if (socks <= 3)
            {
                Console.WriteLine("Time to do laundry!.");
            }
            else
            {
                Console.WriteLine("You don't need to take your laundry.");
            }
        }
    }
}