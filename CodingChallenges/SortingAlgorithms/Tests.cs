using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenges.Utilities;
using CodingChallenges.SortingAlgorithms;

namespace CodingChallenges
{ 
    static class Tests
    {
        public static void SortBubble()
        {
            Log.Title("Bubble Sort");

            int[] sortedArray = BubbleSort.SortArray(Sorting.RandomIntArray(100), true);

            List<int> sortedList = BubbleSort.SortList(Sorting.RandomIntList(100), false);
        }

        public static void SortSelection()
        {
            Log.Title("Selection Sort");
            
            int[] sortedArray = SelectionSort.SortArray(Sorting.RandomIntArray(100), true);

            List<int> sortedList = SelectionSort.SortList(Sorting.RandomIntList(100), false);
        }

        public static void SortInsertion()
        {
            Log.Title("Insterion Sort");

            int[] sortedArray = InsertionSort.SortArray(Sorting.RandomIntArray(100), true);

            List<int> sortedList = InsertionSort.SortList(Sorting.RandomIntList(100), false);
        }
    }
}
