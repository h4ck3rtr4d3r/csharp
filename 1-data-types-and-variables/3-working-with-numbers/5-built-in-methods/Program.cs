/*
  There are several built-in methods that we can use to manipulate numerical data and perform more complex mathematical calculations. Here are a few examples:

  - Math.Abs() will find the absolute value of a number. E.g. Math.Abs(-5) will return 5.
  - Math.Sqrt() will find the square root of a number. E.g. Math.Sqrt(25) will return 5.
  - Math.Floor() will round the given double or decimal down to the nearest whole number. E.g. Math.Floor(3.14) will return 3.
  - Math.Min() returns the smaller of two numbers. E.g. Math.Min(5, 10) will return 5.
*/

using System;
namespace LowestNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Starting variables
      int numberOne = 12932;
      int numberTwo = -2828472;

      // Use built-in methods and save to variable 
      double numberOneSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberOne)));

      // Use built-in methods and save to variable 
      double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numberTwo)));

      // Print the lowest number
      Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));

    }
  }
}
