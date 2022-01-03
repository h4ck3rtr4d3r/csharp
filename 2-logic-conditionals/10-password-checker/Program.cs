using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a password: ");
            string password = Console.ReadLine();
            int score = 0;

            // If the password is greater than or equal to the minimum length, add a point to the score.
            if (password.Length >= 8)
            {
                score++;
            }
            else if (password.Length > 20)
            {
                Console.WriteLine("Password must be less than 20 characters long.");
            }
            else if (!password.Any(char.IsDigit))
            {
                Console.WriteLine("Password must contain at least one number.");
            }
            else if (!password.Any(char.IsUpper))
            {
                Console.WriteLine("Password must contain at least one uppercase letter.");
            }
            else if (!password.Any(char.IsLower))
            {
                Console.WriteLine("Password must contain at least one lowercase letter.");
            }
            else if (!password.Any(char.IsPunctuation))
            {
                Console.WriteLine("Password must contain at least one punctuation character.");
            }
            else
            {
                Console.WriteLine("Password is valid.");
            }
        }
    }
}