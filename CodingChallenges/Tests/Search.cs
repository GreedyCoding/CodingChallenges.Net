using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenges.Utilities;
using CodingChallenges.SortingAlgorithms;
using CodingChallenges.SearchAlgorithms;

namespace CodingChallenges.Tests
{ 
    internal static class Search
    {
        public static void Binary()
        {
            Log.Title("Binary Search");
            int tries = 5;
            Console.WriteLine($"You have '{tries}' tries to check an array with 50 randoms ints for an integer.");
            for (int i = 0; i < 5; i++)
            {
                int[] sortedArray = BubbleSort.SortArray(Sorting.RandomIntArray(50, 100), true, false);

                Console.WriteLine("Please input an integer between 1 and 100");
                int toSearchFor = Convert.ToInt32(Console.ReadLine());

                int indexOfValue = BinarySearch.Search(sortedArray, toSearchFor);

                if (indexOfValue == -1)
                {
                    Console.WriteLine("The provided value was not found in the array");
                }
                else
                {
                    Console.WriteLine($"The provided value '{toSearchFor}' was found at the following index: '{indexOfValue}'");
                }
            }


        }
    }
}
