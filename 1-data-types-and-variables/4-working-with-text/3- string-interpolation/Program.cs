/*
  While string concatenation is easy to read, it can get annoying to write.Another option is string interpolation. String Interpolation was introduced in C# 6 and it enable us to insert our variable values and expressions in the middle of a string, without having to worry about spaces and punctuation.

    string youFaveMusician = "David Bowie";
    string myFaveMusician = "Hans Zimmer";

    Console.WriteLine($"Your favorite musician is {youFaveMusician} and mine is {myFaveMusician}");

  Notice how we just have one string, which we append with the dollar sign symbol $. Make sure there isn't space between the $ and the starting quotation mark ". Whenever we need to insert a variable, we surround it with braces {}.
  
*/

using System;
namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time,";
      string middle = "The kid climbed a tree";
      string end = "Everyone lived happily ever after.";

      // Interpolate the strings
      string story = $"{beginning} {middle} {end}";

      //Print the story to the console
      Console.WriteLine(story);
    }
  }
}
