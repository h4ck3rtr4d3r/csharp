/*
  We can also use built-in  .NET methods to grab parts of strings or specific characters in a string.

  Substing
  .Substring() grabs part of a string using the specified character position and continues until the end of the string and returns a new string. .IndexOf() is usually used first to get the specific character position.

    string plantName = "Cactaceae, Cactus";
    int charPosition = plantName.IndexOf("Cactus"); // returns 11.
    string commonName = plantName.Substring(charPosition); // returns Cactus.

  .Substring() is useful if we only want to use part of a string, but keep the original data intact. So in this instance, we want to keep the string plantName, but just grab the "Cactus" portion of the string. We use .IndexOf() to find where "Cactus" starts, then use .Substring() with the position information to save "Cactus" to the new variable commonName.

    string plantName = "Cactaceae, Cactus";
    int charPosition = plantName.IndexOf("u"); // returns 15.
    char u = plantName[charPosition]; // returns u.

  Similar to the example above, we first use .IndexOf() to grab the character position, which in this case is 15. We then take the sting value and append it with a set of brackets [] and place the charPosition value inside the brackets.
  
*/

using System;
namespace NameGrab
{
  class Program
  {
    static void Main(string[] args)
    {
      // User Name
      string name = "Farhad Hesam Abbasi";
      // Get first letter
      int charPosition = name.IndexOf("F");
      char firstLetter = name[charPosition];

      // Get last name
      int lastNamePosition = name.IndexOf(" Hesam Abbasi");
      string lastName = name.Substring(lastNamePosition);

      // Print results
      Console.WriteLine("First Letter: " + firstLetter);
      Console.WriteLine("Last Name: " + lastName);
      

    }
  }
}
