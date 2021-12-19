/*
  So what can we do with numerical data A first step is to wrtie expressions using arithmetic operators.
  Arithmetic operators include:
  - Addition: +
  - Subtraction: -
  - Multiplication: *
  - Division: /

  We can use these symbols to perform operations on numbers and create new values.

    int answer = 4 + 19;
    Console.WriteLine(answer); 
    
    // prints 23
  
  When using operators, it's important to pay attention to data types. if we use two integers, it will return an integer every time. However, if we combine an integer with a double, the answer will be a double. Let's look at the following example:

    Console.WriteLine(5/3);
    Console.WriteLine(5/3.0);

    // prints 1
    // prints 1.6666666666666667

  Te first operation that we log uses two ints.While 3 doesn't go into 5 evenly, we are still left with an int whole number. In the second operation, we use an int and a double, so the final result is a double.

  C# follows the order of operations. If we do 1+2*3, should the answer be 9 or 7? C# folows a set of rules to determine which opeartions to perform first (the answer is 7). It's good practice to use parentheses to eplicitly tell C# how to calculate these expressions.

  Notice in the following example, even if the additionsymbol appears like it should come first, the multiplication operation will happen first.

    int answer = 8 +(9*3);
    Console.WriteLine(answer);

    // prints 27  
*/

using System;

namespace PlanetCaculations
{
  class Program
  {
    static void Main(string[] args)
    {
      // Your Age
      int userAge = 39;

      // Length of years on Jupiter (in Earth years)
      double jupiterYears = 11.86;

      // Age on Jupiter
      double jupiterAge = userAge / jupiterYears;

      // Time to Jupiter
      double journeyToJupiter = 6.142466;

      // New Age on Earth
      double newEarthAge = userAge + journeyToJupiter;

      // New Age on Jupiter
      double newJupiterAge = newEarthAge / jupiterYears;

      // Log the results
      Console.WriteLine("Your age on Earth is: " + userAge);
      Console.WriteLine("Your age on Jupiter is: " + jupiterAge);
      Console.WriteLine("Your age on Earth after a journey to Jupiter is: " + newEarthAge);
      Console.WriteLine("Your age on Jupiter after a journey to Jupiter is: " + newJupiterAge);

    }
  }
}