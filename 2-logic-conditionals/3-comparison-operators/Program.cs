/*
 When writing a program, we often need to check if a value is correct or compare two values. Comparison operators allow us to compare values and evaluate their relationship. Rather than evaluating to an intenger, they evalute to a boolean value. Expressions that evaluate to boolean values are known as boolen expressions.

 Comparison operators include:
    == (equal to) returns true if the value to the left is equal to the value to the right.
    != (not equal to) returns true if the value to the left is not equal to the value to the right.
    < (less than) returns true if the value to the left is less than the value to the right.
    <= (less than or equal to) returns true if the value to the left is less than or equal to the value to the right.
    > (greater than) returns true if the value to the left is greater than the value to the right.
    >= (greater than or equal to) returns true if the value to the left is greater than or equal to the value to the right.

 Here's what a boolean expression using comparison operators looks like:

    bool answer = 3 < 75;
    Console.WriteLine(answer); // prints true
 
 In this example, we use less than < comparisson operator to compare the values 3 and 75, then save the expression to a variable called answer whith a boolean data type. If we were to print the value of answer to the console, it would print out true, since the number 3 is less than the number 75.
 In addition to comparing intengers, we can also compare variables, strings, and even boolean values.

*/

using System;
namespace ComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a double variable named timeToDinner and save the difference in hours beteen 2:00pm and 6:00pm.
            double timeToDinner = (6 - 2) * 60;

            // Save the value 95 to a double variable named distance.
            double distance = 95;

            // Save the value 30 to a double variable named rate.
            double rate = 30;

            /*
            Calculate how long it will take us by dividing the distance variable by the rate variable. Write out the expression and save it to the variable tripDuration.
            */
            double tripDuration = distance / rate;

            // Create a bool variable named answer and save the appropriate comparison that checks if tripDuration is less or equal to timeToDinner.
            bool answer = tripDuration <= timeToDinner;

            // Print answer to the console.
            Console.WriteLine(answer);
        }
    }
}