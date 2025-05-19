using ASD.Algorithms.Interfaces;
using System;

namespace ASD.Algorithms.SearchAlgorithms
{
    public class JumpSearch : ISearch
    {
        public int Search(int[] array, int key)
        {
            return JSearch(array, key);
        }

        public static int JSearch(int[] array, int key)
        {
            const int NotFound = -1;
            int length = array.Length;
            if (length == 0) return NotFound;

            int step = (int)Math.Floor(Math.Sqrt(length));
            int prev = 0;
            int k = step;

            while (k < length && array[k - 1] < key)
            {
                prev = k;
                k += step;
            }

            for (int i = prev; i <= Math.Min(k, length - 1); i++)
            {
                if (array[i] == key) return i;
            }

            return NotFound;
        }
    }
}