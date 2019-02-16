using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges.SortingAlgorithms
{
    static class Utilities
    {
        public static int[] SwapElements(int[] array, int indexA, int indexB)
        {
            int temp = array[indexA];
            array[indexA] = array[indexB];
            array[indexB] = temp;
            return array;
        }

        public static List<int> SwapElements(List<int> list, int indexA, int indexB)
        {
            int temp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = temp;
            return list;
        }

        public static void LogContents(int[] array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
        }

        public static void LogContents(List<int> array)
        {
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("------------------------------------------");
        }
    }
}
