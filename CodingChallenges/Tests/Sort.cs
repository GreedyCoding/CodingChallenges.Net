using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenges.Utilities;
using CodingChallenges.SortingAlgorithms;

namespace CodingChallenges.Tests
{ 
    internal static class Sort
    {
        public static void Bubble()
        {
            Log.Title("Bubble Sort");

            int[] sortedArray = BubbleSort.SortArray(Sorting.RandomIntArray(100, 1000), true);

            List<int> sortedList = BubbleSort.SortList(Sorting.RandomIntList(100, 1000), false);
        }

        public static void Selection()
        {
            Log.Title("Selection Sort");
            
            int[] sortedArray = SelectionSort.SortArray(Sorting.RandomIntArray(100, 1000), true);

            List<int> sortedList = SelectionSort.SortList(Sorting.RandomIntList(100, 1000), false);
        }

        public static void Insertion()
        {
            Log.Title("Insterion Sort");

            int[] sortedArray = InsertionSort.SortArray(Sorting.RandomIntArray(100, 1000), true);

            List<int> sortedList = InsertionSort.SortList(Sorting.RandomIntList(100, 1000), false);
        }
    }
}
