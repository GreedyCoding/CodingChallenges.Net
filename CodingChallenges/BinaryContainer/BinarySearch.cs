using System;
using System.Collections.Generic;
using System.Text;
using CodingChallenges.SortingAlgorithms;

namespace CodingChallenges.BinaryContainer
{
    static class BinarySearch
    {
        static int[] _array;

        static int _searchingFor;

        public static int SearchInArray(int[] arr, int value)
        {
            _array = arr;
            _searchingFor = value;

            int _low = 0;
            int _high = _array.Length - 1;
            while (_low <= _high)
            {
                int _middle = _low + (_high - _low) / 2;

                //If the middle spot is the value we are looking for return the value
                if (_array[_middle] == _searchingFor)
                {
                    return _middle;
                }

                //If the value on middle spot is lower set the low point to middle plus 1
                if (_array[_middle] < _searchingFor)
                {
                    _low = _middle + 1;
                }

                //If the value on middle spot is higher set the high point to middle minus 1
                if (_array[_middle] > _searchingFor)
                {
                    _high = _middle - 1;
                }

            }

            //If we do not find the value in the array return -1
            return -1;
        }
    }
}
