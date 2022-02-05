using System;

namespace T08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());

            double resultOne = CalculateFactorial(numOne);
            double resultTwo = CalculateFactorial(numTwo);

            DivideAndPrint(resultOne, resultTwo);
        }

        static double CalculateFactorial(double number)
        {
            double result = 1;

            for (double i = number; i >= 1; i--)
            {
                result *= i;
            }

            return result;
        }

        static void DivideAndPrint(double firstNum, double secondNum)
        {
            Console.WriteLine($"{(firstNum / secondNum):f2}");
        }
    }
}
