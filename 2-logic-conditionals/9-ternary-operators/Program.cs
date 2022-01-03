/*
 The ternary operator allows or a compact syntax in the case of binary decisions. Like an if...else statement, it evaluates a single condition and executes one expression if the condition is true and second expression otherwise.

 Here is an example of the ternary operator:
    string color = "blue";
    string result = (color == "blue") ? "blue" : "not blue";
    Console.WriteLine(result); // prints "blue"

 In this example, e create a variable result and save the outcome of the ternary operator expression. The expression starts ith the Boolean expressions (color == "blue"), followed by the ternary operator ? , then the two possible outcomes, separeted bya colon :. The first outcome, "blue" will be saved to result if the Boolean expression evaluates to true, otherwise it will store the second outcome.

 Ternary operator can also be chained, like else if statements. But careful! Since the entire expression exists on one line, it can quickly become unreadable.

 When using ternary operators, make sure to pay attention to:
 - Parentheses: we place the boolean expression that the statement is evaluating in parentheses().
 - Then ? operator: make sure this comes after the statement and before the outcomes.
 - Colon: This separates the twot possible outcomes.
*/

using System;
namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             You’re growing peppers and wrote a program that lets you know if it’s time to pick them. If a pepper is at least 3.5 inches, it’s time to be picked. If it’s not ready, the program should tell you to “wait a little longer”. Start by creating a string variable named message. Save the comparison statement that checks to see if the pepperLength is 3.5 inches or more. Note: This will throw an error, since we have not completed our statement.
            */
            int pepperLenght = 4;
            string message = (pepperLenght >= 3.5) ? "pick it" : "wait a little longer";
            Console.WriteLine(message);
        }
    }
}