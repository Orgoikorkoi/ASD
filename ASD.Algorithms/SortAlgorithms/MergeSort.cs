using ASD.Algorithms.Interfaces;

namespace ASD.Algorithms.SortAlgorithms
{
    public class MergeSort : ISort
    {
        public void Sort(int[] array)
        {
            SortInternal(array);
        }

        public static void SortInternal(int[] array)
        {
            if (array == null || array.Length <= 1)
            {
                return;
            }

            int[] buffer = new int[array.Length];
            MergeSortRecursive(array, buffer, 0, array.Length - 1);
        }

        private static void MergeSortRecursive(int[] array, int[] buffer, int left, int right)
        {
            if (left >= right)
            {
                return;
            }

            int mid = (left + right) / 2;

            MergeSortRecursive(array, buffer, left, mid);
            MergeSortRecursive(array, buffer, mid + 1, right);

            Merge(array, buffer, left, mid, right);
        }

        private static void Merge(int[] array, int[] buffer, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;

            while (i <= mid && j <= right)
            {
                if (array[i] <= array[j])
                {
                    buffer[k++] = array[i++];
                }
                else
                {
                    buffer[k++] = array[j++];
                }
            }

            while (i <= mid)
            {
                buffer[k++] = array[i++];
            }

            while (j <= right)
            {
                buffer[k++] = array[j++];
            }

            for (int l = left; l <= right; l++)
            {
                array[l] = buffer[l];
            }
        }
    }
}