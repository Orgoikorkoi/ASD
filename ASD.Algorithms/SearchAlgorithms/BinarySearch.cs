namespace ASD.Algorithms.SearchAlgorithms
{
    public class BinarySearch
    {
        public static int BinSearch(int[] array, int key)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == key)
                {
                    return mid;
                }
                else if (array[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;
        }
    }
}