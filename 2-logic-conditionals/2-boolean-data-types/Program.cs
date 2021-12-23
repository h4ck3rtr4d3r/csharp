/*
    In C# we can represent Boolean values using the bool data type. Booleans, unlike numbers or strings, only have two values: true and false.

    To define a variable as a boolean, you define the data type as bool. Then write the variable name and set it equal to the value, eithger true or false:
     
        bool variableName = true;
    
    The variable is named variableName, its of type bool, and it is set to the value true.

    While we use the words true and false to represent boolean values, it's important to remember that they are different from the strings "true" and "false".
*/
using System;
namespace BooleanDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // True or False: The number 500 is greater than 24? Print the question and the answer.
            Console.WriteLine("True or False: The number 500 is greater than 24?");
            bool isGreater = 500 > 24;
            Console.WriteLine(isGreater);

            // True or False: “coffee” contains the letter “a”.
            Console.WriteLine("True or False: \"coffee\" contains the letter \"a\".");
            bool containsA = "coffee".Contains("a");
            Console.WriteLine(containsA);
        }
    }
}