using System;

namespace T04._Password_Validator_Retake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MinCharacters = 6;
            const int MaxCharacters = 10;
            const int RequiredDigits = 2;

            string password = Console.ReadLine();

            CheckIfPasswordIsValid(password, MinCharacters, MaxCharacters, RequiredDigits);
        }

        static void CheckIfPasswordIsValid(string password, int minChar, int maxChar, int requiredDigits)
        {
            bool isValidPassword = true;

            if (!CheckIfHasRequiredChars(password, minChar, maxChar))
            {
                Console.WriteLine($"Password must be between {minChar} and {maxChar} characters");
                isValidPassword = false;
            }

            if (!CheckIfHasOnlyLetterAndDigits(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValidPassword = false;
            }

            if (!CheckIfContainsRequiredDigits(password, requiredDigits))
            {
                Console.WriteLine($"Password must have at least {requiredDigits} digits");
                isValidPassword = false;
            }

            if (isValidPassword)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckIfHasRequiredChars(string password, int minChars, int maxChars)
        {
            if (password.Length < minChars || password.Length > maxChars)
            {
                return false;
            }

            return true;
        }

        static bool CheckIfHasOnlyLetterAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                char currentSymbol = password[i];

                if (!Char.IsLetterOrDigit(currentSymbol))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Checks if the password has the required digits.
        /// </summary>
        static bool CheckIfContainsRequiredDigits(string password, int requiredDigits)
        {
            int countOfDigits = 0;

            foreach (char element in password)
            {
                if (Char.IsDigit(element))
                {
                    countOfDigits++;
                }
            }

            if (countOfDigits < requiredDigits)
            {
                return false;
            }

            return true;
        }
    }
}
