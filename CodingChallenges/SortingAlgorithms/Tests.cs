using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenges.SortingAlgorithms;

namespace CodingChallenges
{ 
    static class Tests
    {
        public static void SortBubble()
        {
            Utilities.LogTitle("Bubble Sort");

            int[] sortedArray = BubbleSort.SortArray(Utilities.RandomIntArray(100), true);

            List<int> sortedList = BubbleSort.SortList(Utilities.RandomIntList(100), false);
        }

        public static void SortSelection()
        {
            Utilities.LogTitle("Selection Sort");
            
            int[] sortedArray = SelectionSort.SortArray(Utilities.RandomIntArray(100), true);

            List<int> sortedList = SelectionSort.SortList(Utilities.RandomIntList(100), false);
        }

        public static void SortInsertion()
        {
            Utilities.LogTitle("Insterion Sort");

            int[] sortedArray = InsertionSort.SortArray(Utilities.RandomIntArray(100), true);

            List<int> sortedList = InsertionSort.SortList(Utilities.RandomIntList(100), false);
        }
    }
}
