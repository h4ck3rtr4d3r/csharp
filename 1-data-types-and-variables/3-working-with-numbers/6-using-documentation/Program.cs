/*
  Now's a good time to use the documentation and practice documentation search skills.
  Take a moment to look up the following built-in methods to understand their usage:
  - Math.Pow()
  - Math.Max()
  - Math.Ceiling()

  If you're having trouble locating what you need, we recommend the MIcrosoft .NET API Documentation.
*/
using System;
namespace DocumentationHunt
{
  class Program
  {
    static void Main(string[] args)
    {
      double numberOne = 6.5;
      double numberTwo = 4;

      // Raise numberOne to he numberTwo power
      Console.WriteLine(Math.Pow(numberOne, numberTwo));

      // Round numberOne up
      Console.WriteLine(Math.Ceiling(numberOne));

      // Find the largest number between numberOne and numberTwo
      Console.WriteLine(Math.Max(numberOne, numberTwo));
    }
  }
}