/*
When you're first starting to learn a strongly-typed language, erros can be prety common.
So, what happens if you forget to specify a data type for your variable?

      randomData = "asdf jskdfj";
      Console.WriteLine(randomData);

  C# will give an error because it doesn't want you to have random data being used in your application.  If you use the wrong type definition, like an int when it's supposed to be a double for example.
   
      int score = 45.39

  This will give an error because the variable is not defined as an int. You might see an error like this:

      Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)
  
  We also want to watch out for how we name our variables. It's good practice to use camelCase styling, and they should only contain underscores, letters, and digits.

    string iAmVariable;
    string i'mnot; // this is an error

  There are also a few words that you can't use. these are know as reserved keywords. 
*/

using System;
namespace BugSquasher
{
  class Program
  {
    static void Main(string[] args)
    {
      double number = 45.39;
      Console.WriteLine(number);

      string dinosaur = "T-Rex";
      Console.WriteLine(dinosaur);

      double _lock = 293.000;
      Console.WriteLine(_lock);

      bool isTrue = true;
      Console.WriteLine(isTrue);

      string band = "The Low Anhem";
      Console.WriteLine(band);
    }
  }
}

