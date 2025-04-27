namespace ASD.Algorithms.SortAlgorithms
{
    public class MergeSort
    {
        public static int[] Sort(int[] S)
        {
            return MergeSortRecursive(S, S.Length);
        }

        private static int[] MergeSortRecursive(int[] S, int len)
        {
            if (len <= 1)
            {
                int[] result = new int[len];
                Array.Copy(S, result, len);
                return result;
            }

            int m = len / 2;

            int[] left = new int[m];
            int[] right = new int[len - m];

            Array.Copy(S, 0, left, 0, m);
            Array.Copy(S, m, right, 0, len - m);

            return Merge(MergeSortRecursive(left, m), MergeSortRecursive(right, len - m));
        }

        private static int[] Merge(int[] left, int[] right)
        {
            List<int> result = [];
            int i = 0;
            int j = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }

            while (i < left.Length)
            {
                result.Add(left[i]);
                i++;
            }

            while (j < right.Length)
            {
                result.Add(right[j]);
                j++;
            }

            return result.ToArray();
        }
    }
}