/*
  Often, we want to combine strings together, o combine strings with a value that we've saved to a variable.

  A common way to do is by using string concatenation. String concatenation is when we combine strings using the addition symbol (+), literally adding one string to another.

    string yourFaveMusician = "Hanz Zimmer";
    string mFaveMusician = "The Beatles";

    Console.WriteLine("Your favorite musician is " + yourFaveMusician + " and my favorite musician is " + mFaveMusician + ".");

  We write the first part of our string, en it with a double quote ("), include an addition symbol and then put our variable. However, there are a couple of thigs to pay attention to:

    - If we want to concatenate a string wih something that is another data type, C# will implicity convert that value to a string.
    - Make sure that you include spaces and proper punctuation so that when it prints out, your variable strings aren't squished between the rest of the statement. Notice how we have to create a one character string at the end to include a period.
  */

using System;

namespace StoryTime
{
  class Program
  {
    static void Main(string[] args)
    {
      // Declare the variables
      string beginning = "Once upon a time, ";
      string middle = "a little boy,  ";
      string end = "go to school.";


      // Concatenate the string and the variables
      string story = beginning + middle + end;

      // Print the story to the console 
      Console.WriteLine(story);
    }
  }
}
