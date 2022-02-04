﻿using System;

namespace T07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintNxNMatrix(number);
        }

        static void PrintNxNMatrix(int number)
        {
            for (int rows = 0; rows < number; rows++)
            {
                for (int columns = 0; columns < number; columns++)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
