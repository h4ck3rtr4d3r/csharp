/*
  A modulo returns a remainder, what is left over when we divide a number by another number.
  
    4 % 3 = 1
    4 % 2 = 0

  The modulo is the same as the percentage symbol, but it's importatn to remmeber it's different meaning in this context.
  Modulos are useful because they let us know if a number "fits" into a larger number, or if there will be a remainder. For example, how many eggs will be left over if I try and fit 56 eggs into crates of a dozen eggs?

    int eggs = 56;
    int crateAmount = 12;

    int eggsLeftOver = eggs % crateAmount;
    Console.WriteLine(eggLeftOver); // prints 8

  It can also be used to check if a number is odd or even. If a number is even, taking its modulo with 2 it will retun a 0 and if it is odd it will return 1:

    int myNum = 85939824;
    Console.Write(myNum % 2); // prints 0, so number is even
*/

using System;
namespace ClassTeams
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of students
      int students = 18;

      // Number if students in a group
      int groupSize = 4;

      // Does groupSize go evenly into students?
      Console.WriteLine(students % groupSize);

    }
  }
}
