/*
    As we saw in the truth table, a Boolean expression that uses logical operators can be as simple as evaluating two boolean values:
        bool answer = true && false; // evaluates to false.
    In this case, we're saying that answer is equal to the evaluation of true AND false. According to the truth table, answer is false.

    But more often, Boolean expressions are extremely complex. Rather than determining if one relationship is true or false, e can evaluate several expressions by connecting them with logical operators and then determining the validity of the overall expression.
        bool answer = (9 < 3) || (100 < 45); // evaluates to false. 
        bool another = ((3439 > 40) && (1 < 3)) || answer; // evaluates to true.
    We can use logical values to start chaining logical statements. Let's start by fiding the value kof answer.
    First, the computer will evaluate each comparisson statement:
        bool answer = (9 < 3) || (100 < 45); // evaluates to false.
        bool answe = false || false; // evaluates to false.
    Since both statements are false and we're using OR operator, the overall expression will return false.
        bool answer = false 
    Now we can start evaluating the value of another. Again, we'll start by evaluating the comparisson statements:
        bool another = ((3439 > 40) && (1 < 3)) || answer; // evaluates to true.
        bool another = (true && true) || answer;
    Since both statements are true and we're using AND operator, the overall expression will return true.
        bool another = true || answer;
    Since we already know that answer is false and we're evaluating it with a true value using OR operator another, it will return true:
        bool another = true; 
     
*/
using System;
namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool beach = true;
            bool hiking = false;
            bool city = true;

            /*
            You and your friend are planning a trip together and are trying to decide where to go. You each have specific criteria that it needs to fulfill. You want it to have a beach and a city. Create a bool variable named yourNeeds. Write a logical comparison that captures your criteria.
            */
            bool yourNeeds = (beach && city);

            /*
            Your friend wants a beach or hiking. Create a bool variable named friendNeeds. Write a logical comparison that captures their criteria.
            */
            bool friendNeeds = (beach || hiking);

            /*
            Your current pick is Barcelona, which is a city that has a beach. Will both you and your friend be happy? Write a logical comparison that compares yourNeeds and friendNeeds and save it to tripDecision.
            */
            bool tripDecision = (yourNeeds && friendNeeds);

            // Print out tripDecision.
            Console.WriteLine(tripDecision);
        }
    }
}
