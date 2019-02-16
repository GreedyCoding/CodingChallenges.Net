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
            int[] arrayToSort = new int[] { 98, 19, 31, 99, 55, 78, 33, 9, 20, 17, 77, 2, 21, 1 };

            List<int> listToSort = new List<int> { 98, 19, 31, 99, 55, 78, 33, 9, 20, 17, 77, 2, 21, 1 };

            int[] sortedArray = BubbleSort.SortArray(arrayToSort, true);

            List<int> sortedList = BubbleSort.SortList(listToSort, false);
        }

        public static void SortSelection()
        {
            int[] arrayToSort = new int[] { 88, 19, 31, 63, 55, 78, 3, 9, 22, 17, 77, 2, 11, 1 };

            List<int> listToSort = new List<int> { 88, 19, 31, 63, 55, 78, 3, 9, 22, 17, 77, 2, 11, 1 };

            int[] sortedArray = SelectionSort.SortArray(arrayToSort, true);

            List<int> sortedList = SelectionSort.SortList(listToSort, false);
        }
    }
}
