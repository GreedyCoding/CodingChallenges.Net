using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges.SortingAlgorithm
{
    static class Tests
    {
        public static void SortBubble()
        {
            int[] arrayToSort = new int[] { 98, 19, 31, 99, 55, 78, 33, 9, 20, 17, 77, 2, 21, 1 };

            List<int> listToSort = new List<int> { 98, 19, 31, 99, 55, 78, 33, 9, 20, 17, 77, 2, 21, 1 };

            int[] sortedArray = BubbleSort.SortArray(arrayToSort, false);

            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++");

            List<int> sortedList = BubbleSort.SortList(listToSort, true);
        }
    }
}
