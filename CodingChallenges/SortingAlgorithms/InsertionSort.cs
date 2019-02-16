using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenges.Utilities;

namespace CodingChallenges.SortingAlgorithms
{
    class InsertionSort
    {
        public static int[] SortArray(int[] toSort, bool ascending)
        {
            int[] _result = toSort;

            bool _ascending = ascending;

            //Logging the array contents to the console
            Console.WriteLine("This number sequence is going to be sorted:");
            Log.ArrayContents(toSort);

            int _size = toSort.Length;
            int _iterations = _size * _size;
            int _iterationCount = 0;

            Console.WriteLine($"The maximum of iterations needed for this lenght would be '{_iterations}'");
            Console.WriteLine("------------------------------------------");

            for (int i = 0; i < _result.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (ascending)
                    {
                        if (_result[j - 1] > _result[j])
                        {
                            Sorting.SwapElements(_result, j - 1, j);
                        }
                    }
                    else
                    {
                        if (_result[j - 1] < _result[j])
                        {
                            Sorting.SwapElements(_result, j - 1, j);
                        }
                    }
                }
                _iterationCount++;
            }

            //Log the result
            if (ascending)
            {
                Console.WriteLine("Here is the Array sorted in ascending order:");
            }
            else
            {
                Console.WriteLine("Here is the Array sorted in descending order:");
            }

            Log.ArrayContents(_result);

            //Log how many iterations were needed to fully sort the array
            Console.WriteLine($"The iterations needed to SelectionSort this array were '{_iterationCount}'");
            Log.Line(ConsoleColor.Yellow);

            return _result;
        }

        public static List<int> SortList(List<int> toSort, bool ascending)
        {
            List<int> _result = toSort;

            bool _ascending = ascending;

            //Logging the array contents to the console
            Console.WriteLine("This number sequence is going to be sorted:");
            Log.ListContents(toSort);

            int _size = toSort.Count;
            int _iterations = _size * _size;
            int _iterationCount = 0;

            Console.WriteLine($"The maximum of iterations needed for this lenght would be '{_iterations}'");
            Console.WriteLine("------------------------------------------");

            //Iterate over the array minus one because we dont need to swap the last element
            for (int i = 0; i < _result.Count - 1; i++)
            {
                //Iterate over the not sorted elements
                for (int j = i + 1; j > 0; j--)
                {

                    if (ascending)
                    {
                        //and check if it is greater then the already sorted elements
                        if (_result[j - 1] > _result[j])
                        {
                            //then swap the two elements until the element in th sorted array is smaller then the element we check
                            Sorting.SwapElements(_result, j - 1, j);
                        }
                    }
                    else
                    {
                        if (_result[j - 1] < _result[j])
                        {
                            Sorting.SwapElements(_result, j - 1, j);
                        }
                    }

                }
                _iterationCount++;
            }

            //Log the result
            if (ascending)
            {
                Console.WriteLine("Here is the Array sorted in ascending order:");
            }
            else
            {
                Console.WriteLine("Here is the Array sorted in descending order:");
            }

            Log.ListContents(_result);

            //Log how many iterations were needed to fully sort the array
            Console.WriteLine($"The iterations needed to SelectionSort this array were '{_iterationCount}'");
            Console.WriteLine();

            return _result;
        }
    }
}



