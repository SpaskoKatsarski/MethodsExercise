using System;

namespace T03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            PrintAllCharsBetweenTwoGivenOnes(firstChar, secondChar);
        }

        static void PrintAllCharsBetweenTwoGivenOnes(char charOne, char charTwo)
        {
            bool firstIsBigger = true;

            if (charOne > charTwo)
            {
                firstIsBigger = false;
            }

            if (firstIsBigger)
            {
                for (int i = charOne + 1; i < charTwo; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = charTwo + 1; i < charOne; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}
