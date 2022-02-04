using System;

namespace T05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = SumNumbers(firstNumber, secondNumber);
            Console.WriteLine(SubstractNumbers(sum, thirdNumber));
        }

        static int SumNumbers(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        static int SubstractNumbers(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
    }
}
