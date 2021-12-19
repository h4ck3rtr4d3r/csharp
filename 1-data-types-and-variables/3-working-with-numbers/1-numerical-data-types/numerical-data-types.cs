/*
  In C#, there are several ways of representing numercal data. Your usage of each will depend on your application. When choosing a data type, think about the following questions:

  Do i need a whole number or do I need something that will represent a fraction, or a decimal? if I want to use a decimal, how precise do i need to be? Depending on you application, whether it's a hobby project or building a B2B financial services software, you will need a diferent data type. Is performance a factor? Most times, choosing a data type that takes up less memory will result in faster applications.

  Let's look at two data types that we can use to represent different numerical values.

  Int.
  An int is a whole integer value, like 4,100 or 2349. They're a good way to count units of things. For example, if we wanted to track the number of coin flips a user makes, we'd use an int. It doesn't make sense to have 0.5 coin flips!

  To define a variable withe the type int, you would write it as follows:
  
    int variableName = 4;
  
  Double and Decimal.
  if we need to use a decimal value, we have a few options: float, double, and decimal. These values are useful for anything that requires more precision than a whole number, like measuriing the precise location of an object in 3D space.

  A double is usually the best choice of the three because it is more precise than a float, but faster to process than a decimal. However, make sure to use a decimal for financial applications, since it is the most precise.

  To define a variable wit the type double, you would write it as follows:
    
    double variableName = 4.59154;
  
  To define a variable with the type decimal, you would write it as follows:
    
    decimal variableName = 489872.76m;
  
  Don't forget the m character after the number! This character tells C# that we're defining a decimal and not a double.
  
*/
using System;
namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      // Number of pizzza shops
      int pizzaShops = 4332;

      // Number of emplyees
      int totalEmployees = 86928;

      // Revenue
      decimal revenue = 390819.28m;

      // Log the values to the console
      Console.WriteLine("Pizza Shops: " + pizzaShops);
      Console.WriteLine("Total Employees: " + totalEmployees);
      Console.WriteLine("Revenue: " + revenue);
    }
  }
}

