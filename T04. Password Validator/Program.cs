using System;
using System.Drawing;

namespace T04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] password = Console.ReadLine().ToCharArray();

            Console.ForegroundColor = ConsoleColor.Red;
            CheckIfThePasswordIsValidOrNot(password);
        }

        static void CheckIfThePasswordIsValidOrNot(char[] input)
        {
            bool isBetween6and10Chars = true;

            if (input.Length > 10 || input.Length < 6)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isBetween6and10Chars = false;
            }

            bool containsOnlyLettersAndDigits = false;
            bool flag = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsLetter(input[i]))
                {
                    continue;
                }
                else if (Char.IsDigit(input[i]))
                {
                    continue;
                }

                flag = false;
            }

            if (flag)
            {
                containsOnlyLettersAndDigits = true;
            }
            else
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            bool hasMoreThanOneDigit = false;

            int countOfDigits = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '1' || input[i] == '2' || input[i] == '3' || input[i] == '4' || input[i] == '5' || input[i] == '6' || input[i] == '7' || input[i] == '8' || input[i] == '9' || input[i] == '0')
                {
                    countOfDigits++;
                }

                if (countOfDigits > 1)
                {
                    hasMoreThanOneDigit = true;
                    break;
                }
            }

            if (!hasMoreThanOneDigit)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isBetween6and10Chars && containsOnlyLettersAndDigits && hasMoreThanOneDigit)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Password is valid");
            }
        }
    }
}
