using ASD.Algorithms.Interfaces;

namespace ASD.Algorithms.SortAlgorithms
{
    public class SelectionSort : ISort
    {
        public void Sort(int[] array)
        {
            SortInternal(array);
        }

        public static void SortInternal(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}