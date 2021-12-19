/*
  In addition to containing the value of a piece of textm strings also contain information about themselves. It can be useful to know these properties when woking with strings. There are several built-in .NET methods that we can use to get more information about strings.

  Length
  Since strings are composed of a set of characters, we can find out how many characters exist in a string with the .Length method. A common example is if we're buiding a form and need to make sure a user submission doesn't exceed a certain character length.

    string userTweet = Console.ReadLine();
    userTweet.Length; // returns the length of the string

  We append the .Length property to a string that we have, such as user's tweet.

  IndexOf
  We can also find the position of a specific character or substring using .IndexOf(). This method is useful for searching to see if something exists in a string.
  if it does exist within a string, the method will return the position of the search term in the larger string. Each character in a string has a unique position, like an address. Positions stats at 0 and increment by 1.

    string word = Console.ReadLine();
    userTweet.IndexOf("a"); // returns the position of the first "a" in the string

  Since positioning starts at 0, the second thing in the string will return a 1. If it doesn't exist in the string the method will return -1. if we pass it an empty string, it will return 0. if it occurs more than once, it will return the first instance.
*/

using System;
namespace PasswordCheck
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create a password
      string password = "a92301j2add";

      // Get password length
      int passwordLength = password.Length;

      //Check if password uses symbol
      int passwordCheck = password.IndexOf("!");
    }
  }
}