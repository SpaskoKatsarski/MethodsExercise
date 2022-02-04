using System;

namespace T01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            PrintSmallestNumber(firstNum, secondNum, thirdNum);
        }

        static void PrintSmallestNumber(int numOne, int numTwo, int numThree)
        {
            int smallestNum = 0;

            if (numOne < numTwo && numOne < numThree)
            {
                smallestNum = numOne;
            }
            else if (numTwo < numOne && numTwo < numThree)
            {
                smallestNum = numTwo;
            }
            else
            {
                smallestNum = numThree;
            }

            Console.WriteLine(smallestNum);
        }
    }
}
