using System;

namespace T06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            PrintMiddleChar(text);
        }

        static void PrintMiddleChar(string text)
        {
            if (text.Length % 2 == 0)
            {
                Console.Write(text[text.Length / 2 - 1]);
            }

            for (int i = 0; i < text.Length; i++)
            {
                if (text.Length / 2 == i)
                {
                    Console.Write(text[i]);
                }
            }
        }
    }
}
