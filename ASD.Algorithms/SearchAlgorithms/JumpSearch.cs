using System;

namespace ASD.Algorithms.SearchAlgorithms
{
    public class JumpSearch
    {
        public static int Search(int[] array, int key)
        {
            int length = array.Length;

            if (length == 0)
                return -1;

            int k = (int)Math.Floor(Math.Sqrt(length));
            int prev = 0;

            while (array[Math.Min(k, length) - 1] < key)
            {
                prev = k;
                k += (int)Math.Floor(Math.Sqrt(length));
                if (prev >= length)
                    return -1;
            }

            for (int i = prev; i < Math.Min(k, length); i++)
            {
                if (array[i] == key)
                    return i;
            }

            return -1;
        }
    }
}