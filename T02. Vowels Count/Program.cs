using System;

namespace T02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintNumberOfVowels(input);
        }

        static void PrintNumberOfVowels(string givenString)
        {
            int countOfVowels = 0;

            for (int i = 0; i < givenString.Length; i++)
            {
                if (Char.ToLower(givenString[i]) == 'a' || Char.ToLower(givenString[i]) == 'i' || Char.ToLower(givenString[i]) == 'o' || Char.ToLower(givenString[i]) == 'u' || Char.ToLower(givenString[i]) == 'e' || Char.ToLower(givenString[i]) == 'y')
                {
                    countOfVowels++;
                }
            }

            Console.WriteLine(countOfVowels);
        }
    }
}
