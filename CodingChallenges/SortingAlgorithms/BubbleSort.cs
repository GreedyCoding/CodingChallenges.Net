using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenges.Utilities;

namespace CodingChallenges.SortingAlgorithms
{
    static class BubbleSort
    {

        public static int[] SortArray(int[] toSort, bool ascending)
        {  
            //Getting the Array to Sort
            int[] _result = toSort;

            bool _ascending = ascending;

            //Logging the array contents to the console
            Console.WriteLine("This number sequence is going to be sorted:");
            Log.ArrayContents(toSort);

            //Getting the size of the array to calculate the maximum needed iterations for the bubble sort
            int _size = toSort.Length;
            int _iterations = (_size * (_size - 1)) / 2;
            
            Console.WriteLine($"The maximum of iterations needed for this lenght would be '{_iterations}'");
            Console.WriteLine("------------------------------------------");

            int _iterationCount = 0; //Keeps track of the iterations taken

            //Iterating over the array for the maximum needed iterations
            for (int i = 0; i < _iterations; i++)
            {
                int _swaps = 0; //Keeps track of the number of swaps in this iteration

                //Iterating over all items. Length - 1 because we always check the current and next value
                for (int j = 0; j < _result.Length - 1; j++)
                {
                    //First Value
                    int value = _result[j];
                    //Second Value to compare
                    int toCompare = _result[j + 1];
                    if (ascending)
                    {
                        if (toCompare < value)
                        {
                            //Swap the numbers
                            _result[j] = toCompare;
                            _result[j + 1] = value;
                            //Increase swap counter by 1
                            _swaps += 1;
                        }
                    }
                    else
                    {
                        if (toCompare > value)
                        {
                            //Swap the numbers
                            _result[j] = toCompare;
                            _result[j + 1] = value;
                            //Increase swap counter by 1
                            _swaps += 1;
                        }
                    }

                }
                //Increase iteration counter by one
                _iterationCount += 1;

                //If no swaps happened in this iteration we break because everything is sortedd
                if (_swaps == 0) break;
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
            Console.WriteLine($"The iterations needed to BubbleSort this array were '{_iterationCount}'");
            Log.Line(ConsoleColor.Yellow);

            return _result;
        }

        public static List<int> SortList(List<int> toSort, bool ascending)
        {
            //Getting the Array to Sort
            List<int> _result = toSort;

            bool _ascending = ascending;

            //Logging the array contents to the console
            Console.WriteLine("This number sequence is going to be sorted:");
            Log.ListContents(toSort);

            //Getting the size of the array to calculate the maximum needed iterations for the bubble sort
            int _size = toSort.Count;
            int _iterations = (_size * (_size - 1)) / 2;
            Console.WriteLine($"The maximum of iterations needed for this lenght would be '{_iterations}'");
            Console.WriteLine("------------------------------------------");

            int _iterationCount = 0; //Keeps track of the iterations taken

            //Iterating over the array for the maximum needed iterations
            for (int i = 0; i < _iterations; i++)
            {
                int _swaps = 0; //Keeps track of the number of swaps in this iteration

                //Iterating over all items. Length - 1 because we always check the current and next value
                for (int j = 0; j < _result.Count - 1; j++)
                {
                    //First Value
                    int value = _result[j];
                    //Second Value to compare
                    int toCompare = _result[j + 1];
                    if (ascending)
                    {
                        if (toCompare < value)
                        {
                            //Swap the numbers
                            _result[j] = toCompare;
                            _result[j + 1] = value;
                            //Increase swap counter by 1
                            _swaps += 1;
                        }
                    }
                    else
                    {
                        if (toCompare > value)
                        {
                            //Swap the numbers
                            _result[j] = toCompare;
                            _result[j + 1] = value;
                            //Increase swap counter by 1
                            _swaps += 1;
                        }
                    }

                }
                //Increase iteration counter by one
                _iterationCount += 1;

                //If no swaps happened in this iteration we break because everything is sortedd
                if (_swaps == 0) break;
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
            Console.WriteLine($"The iterations needed to BubbleSort this array were '{_iterationCount}'");

            return _result;
        }

    }
}
