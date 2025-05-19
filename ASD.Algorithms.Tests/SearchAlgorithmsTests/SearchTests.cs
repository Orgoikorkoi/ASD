using ASD.Algorithms.Interfaces;
using ASD.Algorithms.SearchAlgorithms;
using Xunit;
using System;
using System.Collections.Generic;

namespace ASD.Algorithms.Tests.SearchAlgorithmsTests
{
    public class SearchTests
    {
        [Theory]
        [MemberData(nameof(GetSearchImplementations))]
        public void Search_KeyFound_ReturnsCorrectIndex(ISearch search)
        {
            // Arrange
            int[] array = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int key = 7;

            // Act
            int index = search.Search(array, key);

            // Assert
            Assert.Equal(3, index);
        }

        [Theory]
        [MemberData(nameof(GetSearchImplementations))]
        public void Search_KeyNotFound_ReturnsMinusOne(ISearch search)
        {
            int[] array = { 1, 3, 5, 7, 9 };
            int key = 4;

            int index = search.Search(array, key);

            Assert.Equal(-1, index);
        }

        [Theory]
        [MemberData(nameof(GetSearchImplementations))]
        public void Search_EmptyArray_ReturnsMinusOne(ISearch search)
        {
            int[] array = Array.Empty<int>();
            int key = 1;

            int index = search.Search(array, key);

            Assert.Equal(-1, index);
        }

        [Theory]
        [MemberData(nameof(GetSearchImplementations))]
        public void Search_KeyAtStart_ReturnsZero(ISearch search)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int key = 1;

            int index = search.Search(array, key);

            Assert.Equal(0, index);
        }

        [Theory]
        [MemberData(nameof(GetSearchImplementations))]
        public void Search_KeyAtEnd_ReturnsLastIndex(ISearch search)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            int key = 5;

            int index = search.Search(array, key);

            Assert.Equal(4, index);
        }

        [Theory]
        [MemberData(nameof(GetSearchImplementations))]
        public void Search_SingleElementArray_Found(ISearch search)
        {
            int[] array = { 7 };
            int key = 7;

            int index = search.Search(array, key);

            Assert.Equal(0, index);
        }

        [Theory]
        [MemberData(nameof(GetSearchImplementations))]
        public void Search_SingleElementArray_NotFound(ISearch search)
        {
            int[] array = { 7 };
            int key = 5;

            int index = search.Search(array, key);

            Assert.Equal(-1, index);
        }

        [Theory]
        [MemberData(nameof(GetSearchImplementations))]
        public void Search_LargeArray_KeyFound(ISearch search)
        {
            int[] array = new int[1_000_000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            int key = 999_999;

            int index = search.Search(array, key);

            Assert.Equal(999_999, index);
        }

        [Theory]
        [MemberData(nameof(GetSearchImplementations))]
        public void Search_ArrayWithDuplicates_ReturnsAnyValidIndex(ISearch search)
        {
            int[] array = { 1, 3, 3, 3, 5 };
            int key = 3;

            int index = search.Search(array, key);

            Assert.Contains(index, new[] { 1, 2, 3 });
        }

        [Theory]
        [MemberData(nameof(GetSearchImplementations))]
        public void Search_WithMinAndMaxInt_ReturnsCorrectIndices(ISearch search)
        {
            int[] array = { int.MinValue, -100, 0, 100, int.MaxValue };

            int minIndex = search.Search(array, int.MinValue);
            int maxIndex = search.Search(array, int.MaxValue);

            Assert.Equal(0, minIndex);
            Assert.Equal(4, maxIndex);
        }

        [Theory]
        [MemberData(nameof(GetSearchImplementations))]
        public void Search_UnsortedArray_ReturnsMinusOne(ISearch search)
        {
            int[] array = { 5, 3, 1, 2, 4 };
            int key = 4;

            int index = search.Search(array, key);

            Assert.True(index == -1 || array[index] == key);
        }

        public static IEnumerable<object[]> GetSearchImplementations()
        {
            yield return new object[] { new BinarySearch() };
            yield return new object[] { new JumpSearch() };
        }
    }
}