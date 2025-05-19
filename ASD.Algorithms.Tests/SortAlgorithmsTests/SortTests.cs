using ASD.Algorithms.Interfaces;
using ASD.Algorithms.SortAlgorithms;
using Xunit;
using System;
using System.Collections.Generic;

namespace ASD.Algorithms.Tests.SortAlgorithmsTests
{
    public class SortTests
    {
        [Theory]
        [MemberData(nameof(GetSortImplementations))]
        public void Sort_EmptyArray_DoesNotThrow(ISort sorter)
        {
            int[] input = Array.Empty<int>();
            sorter.Sort(input);
            Assert.Empty(input);
        }

        [Theory]
        [MemberData(nameof(GetSortImplementations))]
        public void Sort_SingleElementArray_Untouched(ISort sorter)
        {
            int[] input = { 42 };
            sorter.Sort(input);
            Assert.Equal(new[] { 42 }, input);
        }

        [Theory]
        [MemberData(nameof(GetSortImplementations))]
        public void Sort_AlreadySortedArray_Untouched(ISort sorter)
        {
            int[] input = { 1, 2, 3, 4, 5 };
            sorter.Sort(input);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, input);
        }

        [Theory]
        [MemberData(nameof(GetSortImplementations))]
        public void Sort_ReverseSortedArray_SortsCorrectly(ISort sorter)
        {
            int[] input = { 5, 4, 3, 2, 1 };
            sorter.Sort(input);
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, input);
        }

        [Theory]
        [MemberData(nameof(GetSortImplementations))]
        public void Sort_ArrayWithDuplicates_SortsCorrectly(ISort sorter)
        {
            int[] input = { 4, 2, 5, 2, 3, 1, 4 };
            sorter.Sort(input);
            Assert.Equal(new[] { 1, 2, 2, 3, 4, 4, 5 }, input);
        }

        [Theory]
        [MemberData(nameof(GetSortImplementations))]
        public void Sort_ArrayWithNegativeNumbers_SortsCorrectly(ISort sorter)
        {
            int[] input = { -3, -1, -2, 0, 2, 1 };
            sorter.Sort(input);
            Assert.Equal(new[] { -3, -2, -1, 0, 1, 2 }, input);
        }

        [Theory]
        [MemberData(nameof(GetSortImplementations))]
        public void Sort_AllElementsEqual_SortsCorrectly(ISort sorter)
        {
            int[] input = { 7, 7, 7, 7, 7 };
            sorter.Sort(input);
            Assert.Equal(new[] { 7, 7, 7, 7, 7 }, input);
        }

        [Theory]
        [MemberData(nameof(GetSortImplementations))]
        public void Sort_ArrayWithSingleNegativeNumber_SortsCorrectly(ISort sorter)
        {
            int[] input = { -1, 0, 1, 2, 3 };
            sorter.Sort(input);
            Assert.Equal(new[] { -1, 0, 1, 2, 3 }, input);
        }

        [Theory]
        [MemberData(nameof(GetSortImplementations))]
        public void Sort_ArrayWithLargeNumbers_SortsCorrectly(ISort sorter)
        {
            int[] input = { int.MaxValue, int.MinValue, 0, 100, -100 };
            sorter.Sort(input);
            Assert.Equal(new[] { int.MinValue, -100, 0, 100, int.MaxValue }, input);
        }

        [Theory]
        [MemberData(nameof(GetSortImplementations))]
        public void Sort_TwoElements_SortsCorrectly(ISort sorter)
        {
            int[] input = { 2, 1 };
            sorter.Sort(input);
            Assert.Equal(new[] { 1, 2 }, input);
        }

        public static IEnumerable<object[]> GetSortImplementations()
        {
            yield return new object[] { new InsertionSort() };
            yield return new object[] { new MergeSort() };
            yield return new object[] { new QuickSort() };
            yield return new object[] { new SelectionSort() };
        }
    }
}