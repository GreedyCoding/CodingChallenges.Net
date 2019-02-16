using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges.Utilities
{
    static class Sorting
    {
        public static int[] RandomIntArray (int count, int range)
        {
            int[] data = new int[count];
            Random generator = new Random();
            for (int i = 0; i < count; i++)
            {
                data[i] = generator.Next(0, range);
            }

            return data;
        }

        public static List<int> RandomIntList(int count, int range)
        {
            List<int> data = new List<int>();
            Random generator = new Random();
            for (int i = 0; i < count; i++)
            {
                data.Add(generator.Next(0, range));
            }

            return data;
        }

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
    }
}
