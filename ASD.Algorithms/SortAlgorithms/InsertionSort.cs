namespace ASD.Algorithms.SortAlgorithms
{
    public class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            int len = arr.Length;

            for (int next = 1; next < len; next++)
            {
                int curr = next;
                int temp = arr[next];

                while (curr > 0 && temp < arr[curr - 1])
                {
                    arr[curr] = arr[curr - 1];
                    curr--;
                }

                arr[curr] = temp;
            }
        }
    }
}