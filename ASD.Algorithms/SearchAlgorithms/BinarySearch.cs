using ASD.Algorithms.Interfaces;

namespace ASD.Algorithms.SearchAlgorithms
{
    public class BinarySearch : ISearch
    {
        public int Search(int[] array, int key)
        {
            return BinSearch(array, key);
        }

        public static int BinSearch(int[] array, int key)
        {
            const int NotFound = -1;
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == key)
                {
                    return mid;
                }

                if (array[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return NotFound;
        }
    }
}