using System;
using System.Collections.Generic;
using CodingChallenges.Utilities;


namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //* Sorting Algorithm Tests
            Tests.Sort.Bubble();
            Log.Line(ConsoleColor.Magenta);
            Tests.Sort.Selection();
            Log.Line(ConsoleColor.Magenta);
            Tests.Sort.Insertion();
            //*/

            Console.ReadLine();
        }

    }
}
