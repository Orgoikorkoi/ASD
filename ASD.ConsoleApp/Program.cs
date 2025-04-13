using System;
using ASD.Algorithms.SearchAlgorithms;

internal class Program
{
    private static void Main()
    {
        int[] array = { 1, 3, 5, 7, 9, 11 };
        int key = 7;

        int binIndex = BinarySearch.BinSearch(array, key);
        Console.WriteLine($"BinSearch: index = {binIndex}");

        int jumpIndex = JumpSearch.Search(array, key);
        Console.WriteLine($"JumpSearch: index = {jumpIndex}");
    }
}