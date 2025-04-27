using System;
using Xunit;
using ASD.Algorithms.SortAlgorithms;

namespace ASD.Algorithms.Tests.SortAlgorithms
{
    public class SelectionSortTests
    {
        [Fact]
        public void Sort_EmptyArray_ReturnsEmptyArray()
        {
            // Arrange
            int[] input = Array.Empty<int>();

            // Act
            SelectionSort.Sort(input);

            // Assert
            Assert.Empty(input);
        }

        [Fact]
        public void Sort_SingleElementArray_ReturnsSameArray()
        {
            // Arrange
            int[] input = { 42 };

            // Act
            SelectionSort.Sort(input);

            // Assert
            Assert.Equal(new[] { 42 }, input);
        }

        [Fact]
        public void Sort_AlreadySortedArray_ReturnsSameArray()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };

            // Act
            SelectionSort.Sort(input);

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, input);
        }

        [Fact]
        public void Sort_ReverseSortedArray_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { 5, 4, 3, 2, 1 };

            // Act
            SelectionSort.Sort(input);

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, input);
        }

        [Fact]
        public void Sort_UnsortedArrayWithDuplicates_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { 4, 2, 5, 2, 3, 1, 4 };

            // Act
            SelectionSort.Sort(input);

            // Assert
            Assert.Equal(new[] { 1, 2, 2, 3, 4, 4, 5 }, input);
        }

        [Fact]
        public void Sort_ArrayWithNegativeNumbers_ReturnsSortedArray()
        {
            // Arrange
            int[] input = { -3, -1, -2, 0, 2, 1 };

            // Act
            SelectionSort.Sort(input);

            // Assert
            Assert.Equal(new[] { -3, -2, -1, 0, 1, 2 }, input);
        }
    }
}