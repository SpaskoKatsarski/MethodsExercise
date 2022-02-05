using System;

namespace T10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            PrintTopNumbersUpTo(endNumber);
        }

        static void PrintTopNumbersUpTo(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (IsDigitSumDivisibleBy8(i) && HasOddDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsDigitSumDivisibleBy8(int number)
        {
            int sumDigits = 0;

            while (number != 0)
            {
                sumDigits += number % 10;
                number /= 10;
            }

            if (sumDigits % 8 == 0)
            {
                return true;
            }

            return false;
        }

        static bool HasOddDigit(int number)
        {
            while (number != 0)
            {
                int currentDigit = number % 10;
                number /= 10;

                if (currentDigit % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
