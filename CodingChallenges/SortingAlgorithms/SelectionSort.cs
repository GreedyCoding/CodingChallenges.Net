using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenges.SortingAlgorithms
{
    class SelectionSort
    {
        public static int[] SortArray(int[] toSort, bool ascending)
        {
            int[] _result = toSort;
        
            //Determines the sorting order
            bool _ascending = ascending;

            //Logging the array contents to the console
            Console.WriteLine("This number sequence is going to be sorted:");
            Utilities.LogArrayContents(toSort);

            int _iterationCount = 0;    //Keeps track of the iterations taken
            int lowestIndex;            //Keeps track of the lowerst inddex

            //Iterating over the the array for every element except the last
            for (int i = 0; i < _result.Length - 1; i++)
            {
                //Set first item to be the lowest initially
                lowestIndex = i;

                //Iterate over all numbers to find the lowest number
                for (int index = i + 1; index < _result.Length; index++)
                {
                    if (ascending)
                    {
                        //Check if current item is lower then the item at the lowest index
                        if (_result[index] < _result[lowestIndex])
                        {
                            lowestIndex = index;
                        }
                    }
                    else
                    {
                        //Check if current item is higher then the item at lowers index
                        if (_result[index] > _result[lowestIndex])
                        {
                            lowestIndex = index;
                        }
                    }

                }
                _iterationCount++;

                //Set the lowest index element to the front so we can start iterating at the next element
                Utilities.SwapElements(_result, i, lowestIndex);

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

            Utilities.LogArrayContents(_result);

            //Log how many iterations were needed to fully sort the array
            Console.WriteLine($"The iterations needed to SelectionSort this array were '{_iterationCount}'");
            Console.WriteLine();

            return _result;
        }


        public static List<int> SortList(List<int> toSort, bool ascending)
        {
            List<int> _result = toSort;

            //Determines the sorting order
            bool _ascending = ascending;

            //Logging the array contents to the console
            Console.WriteLine("This number sequence is going to be sorted:");
            Utilities.LogListContents(toSort);

            int _iterationCount = 0;    //Keeps track of the iterations taken
            int lowestIndex;            //Keeps track of the lowerst inddex

            //Iterating over the the array for every element except the last
            for (int i = 0; i < _result.Count - 1; i++)
            {
                //Set first item to be the lowest initially
                lowestIndex = i;

                //Iterate over all numbers to find the lowest number
                for (int index = i + 1; index < _result.Count; index++)
                {
                    if (ascending)
                    {
                        //Check if current item is lower then the item at the lowest index
                        if (_result[index] < _result[lowestIndex])
                        {
                            lowestIndex = index;
                        }
                    }
                    else
                    {
                        //Check if current item is higher then the item at lowers index
                        if (_result[index] > _result[lowestIndex])
                        {
                            lowestIndex = index;
                        }
                    }

                }
                _iterationCount++;


                //Set the lowest index element to the front so we can start iterating at the next element
                Utilities.SwapElements(_result, i, lowestIndex);


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

            Utilities.LogListContents(_result);

            //Log how many iterations were needed to fully sort the array
            Console.WriteLine($"The iterations needed to SelectionSort this list were '{_iterationCount}'");

            return _result;
        }
    }
}

