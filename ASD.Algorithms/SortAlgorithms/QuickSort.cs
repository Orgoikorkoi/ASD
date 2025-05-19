using ASD.Algorithms.Interfaces;

namespace ASD.Algorithms.SortAlgorithms
{
    public class QuickSort : ISort
    {
        public void Sort(int[] array)
        {
            SortInternal(array);
        }

        public static void SortInternal(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
                return;

            QuickSortRecursive(arr, 0, arr.Length - 1);
        }

        private static void QuickSortRecursive(int[] a, int l, int r)
        {
            if (l >= r)
            {
                return;
            }

            int k = Partition(a, l, r);
            QuickSortRecursive(a, l, k - 1);
            QuickSortRecursive(a, k + 1, r);
        }

        private static int Partition(int[] a, int l, int r)
        {
            int pivot = a[r];
            int i = l - 1;

            for (int j = l; j < r; j++)
            {
                if (a[j] <= pivot)
                {
                    i++;
                    Swap(a, i, j);
                }
            }

            Swap(a, i + 1, r);
            return i + 1;
        }

        private static void Swap(int[] a, int i, int j)
        {
            int temp = a[i];
            a[i] = a[j];
            a[j] = temp;
        }
    }
}