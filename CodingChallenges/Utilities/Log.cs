using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges.Utilities
{
    class Log
    {
        public static void ArrayContents(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
        }

        public static void ListContents(List<int> array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
        }

        public static void Title(string str)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(str);
            Console.ResetColor();

        }

        public static void Line(ConsoleColor consoleColor = ConsoleColor.White)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("------------------------------------------");
            Console.ResetColor();
        }
    }
}
