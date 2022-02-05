using System;
using System.Linq;

namespace T09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(CheckIfPalindrome(input));
            }
        }

        static bool CheckIfPalindrome(string currentNumber)
        {
            char[] firstCharArr = currentNumber.ToCharArray();

            char[] reversedNumber = new char[firstCharArr.Length];

            for (int i = 0; i < firstCharArr.Length; i++)
            {
                reversedNumber[i] = firstCharArr[currentNumber.Length - i - 1];
            }

            bool areEqual = true;

            for (int i = 0; i < firstCharArr.Length; i++)
            {
                int currentDigit1 = firstCharArr[i];
                int currentDigit2 = reversedNumber[i];

                if (!(currentDigit1 == currentDigit2))
                {
                    areEqual = false;
                }
            }

            return areEqual;
        }
    }
}
