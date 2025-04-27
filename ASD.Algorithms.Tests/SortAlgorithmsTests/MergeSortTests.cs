using System;
using Xunit;
using ASD.Algorithms.SortAlgorithms;

namespace ASD.Algorithms.Tests.SortAlgorithms
{
    public class MergeSortTests
    {
        [Fact]
        public void Sort_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] input = Array.Empty<int>();

            // Act
            int[] result = MergeSort.Sort(input);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Sort_SingleElementArray_ReturnsSameArray()
        {
            // Arrange
            int[] input = { 42 };

            // Act
            int[] result = MergeSort.Sort(input);

            // Assert
            Assert.Equal(input, result);
        }

        [Fact]
        public void Sort_AlreadySortedArray_ReturnsSameArray()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };

            // Act
            int[] result = MergeSort.Sort(input);

            // Assert
            Assert.Equal(input, result);
        }

        [Fact]
        public void Sort_ReverseSortedArray_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { 5, 4, 3, 2, 1 };
            int[] expected = { 1, 2, 3, 4, 5 };

            // Act
            int[] result = MergeSort.Sort(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Sort_UnsortedArrayWithDuplicates_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { 4, 2, 5, 2, 3, 1, 4 };
            int[] expected = { 1, 2, 2, 3, 4, 4, 5 };

            // Act
            int[] result = MergeSort.Sort(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Sort_ArrayWithNegativeNumbers_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { -3, -1, -2, 0, 2, 1 };
            int[] expected = { -3, -2, -1, 0, 1, 2 };

            // Act
            int[] result = MergeSort.Sort(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}