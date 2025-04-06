using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD
{
    internal class BinarySearch
    {
        static int BinSearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (array[mid] == target)
                    return mid; // znaleziono
                else if (array[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }

            return -1; // nie znaleziono
        }

        static void Main()
        {
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int target = 7;

            int index = BinSearch(sortedArray, target);

            if (index != -1)
                Console.WriteLine($"Znaleziono {target} na indeksie {index}.");
            else
                Console.WriteLine($"{target} nie znaleziono.");}
   }
}
