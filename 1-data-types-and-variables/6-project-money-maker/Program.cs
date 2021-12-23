using System;
namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");

            // Capture user input. Aske the user for the amount to convert and capture he value in a variable.
            Console.WriteLine("Please enter the amount to convert to coins:");
            double amount = Convert.ToDouble(Console.ReadLine());

            // let the user know what you are doing. if the user entered 16, the programa shoul write "16 cents is equal to..."
            Console.WriteLine(amount + " is equal to...");

            // Define two variables that hold those values: a gold coin is worth 10 cents, and a silver coin is worth 5 cent.
            double goldCoin = 10;
            double silverCoin = 5;

            // Calculate how many gold coins fit into the amount.
            double goldCoins = Math.Floor(amount / goldCoin);

            // Use the modulo operator to find the remaining amount and store it in a double variable.
            double remainingAmount = amount % goldCoin;

            // Find the maximum number of silber coins that "fit into the remainder:
            double silverCoins = Math.Floor(remainingAmount / silverCoin);

            // Use the modulo operator to find the remaining amount and store it in the existing remainder variable.
            remainingAmount = remainingAmount % silverCoin;

            // Print outall of the coins! If your input was 16, you should see: 16 cents is equal to 1 gold coin, 1 silver coin, and 0 nickel coins.
            Console.WriteLine(goldCoins + " gold coins, " + silverCoins + " silver coins, and " + remainingAmount + " nickel coins.");

        }
    }
}