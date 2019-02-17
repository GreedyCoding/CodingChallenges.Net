using System;
using System.Collections.Generic;
using CodingChallenges.Utilities;


namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //*/ Sorting Algorithm Tests
            Tests.SortTests.Bubble();
            Log.Line(ConsoleColor.Magenta);
            Tests.SortTests.Selection();
            Log.Line(ConsoleColor.Magenta);
            Tests.SortTests.Insertion();
            //*/ Binary Container Tests
            Log.Line(ConsoleColor.Magenta);
            Tests.BinaryTests.Search();


            Console.ReadLine();
        }

    }
}
