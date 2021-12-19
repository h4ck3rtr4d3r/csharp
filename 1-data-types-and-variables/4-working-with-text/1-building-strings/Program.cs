/*
  A string is a group of characters surrounded by quotation marks, like "https://codefights.com". or "To be or not to be". A string is just a collection of a smaller data type, char, which is a single character like "a" or "b".

  To define a variable as a string, you write the data type, then the varaiable name. Then set it equal to the value, which is insidee of quotation marks.
  
    string variableName = "puppy";

  The variable is named variableName, it's of type sintring, and it's value is puppy.

  Escape Character Senquences
  What happens when you need to include quotes in a string? You can use an escape sequence. An espace sequence places a backslash (\) before inner quotation marks, so the program doesn't read them accidentally as the end of sequence.

    stringwithoutSlash = "Ifemelu said,
    "Hello!""

    string withSlash = "Ifemelu said, \"Hello!\"";
  
  We can use escape characters sequences to create a newline.That means that when we print the string to the console, it will print that line bellow the rest. If printed on its own, it will create an empty line. To create a new line, use the character combination \n

    string newLine = "Ifemelu walked \n to the park.";

*/

using System;

namespace PrideAndPrejudice
{
  class Program
  {
    static void Main(string[] args)
    {
      // First string variable
      string firstSentence = ("It is a truth universally \n acknowledged, that a single man in \n possesion of a good frtune, must be \n in want of a wife");

      // Second string variable
      string firstSpeech = " \"My dear Mr. Bennet,\" said his lady to him one day, \"have you heard that Netherfield Park is let at last?\"";


      Console.WriteLine(firstSentence);
      Console.WriteLine();
      Console.WriteLine(firstSpeech);
    }
  }
}
