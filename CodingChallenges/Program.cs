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
            Tests.Sort.Bubble();
            Log.Line(ConsoleColor.Magenta);
            Tests.Sort.Selection();
            Log.Line(ConsoleColor.Magenta);
            Tests.Sort.Insertion();
            //*/ Search Algorithm Tests
            Log.Line(ConsoleColor.Magenta);2
            Tests.Search.Binary();


            Console.ReadLine();
        }

    }
}
