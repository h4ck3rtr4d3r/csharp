/*
  Because variables have o be strictly typed, there may be some circumstances where we want to change the type of data a variable is storing. This strategy is know as data type conversion.

  For example, let's try converting a double to an integer.

    double myDouble = 3.2;
    int myint = myDouble;
  
  This will not work. The compiler will complain that the double cannot be converted to an integer.
  However, if you did the reverse and turned an int into a double:
  
      int myInt = 3;
      double myDouble = myInt;
  
  This will work. The compiler will convert the int to a double. But why?

  C# checks to make sure that when convert data types from one to another that we're not losing any data, cause that could cause problems.
  Because of that, there are a couple different ways to do data type conversion.

  => Implicit data type conversion: happens automatically if no data will be lost in the conversion. That's why it's possible to convert an int (which can hold less data) to a double (which can hold more data), but not the other way around.

  => Explicit conversion: requires a cast operator to convert a data type into another one. So if we do want to convert a double to an int, we could use the operator (int).

  So, if we're to fix the error in our previous code, we'd rewrite it as follows:

    double myDouble = 3.2;
    int myInt = (int)myDouble;

  It's also possible to convert data types using built-in methods. For most data types, there is a Convert.Tox() method, like Convert.ToString() and Convert.ToDouble(). 
*/

using System;
namespace FavoriteNumber
{
  class Program
  {
    static void Main(string[] args)
    {
      // Ask user for fave number
      Console.WriteLine("What is your favorite number!:");

      // Turn hat answer int an int.
      int faveNumber = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine("Your favorite number is: " + faveNumber);
    }
  }
}
