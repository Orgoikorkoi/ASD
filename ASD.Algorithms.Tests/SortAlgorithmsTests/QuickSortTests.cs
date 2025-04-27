using System;
using Xunit;
using ASD.Algorithms.SortAlgorithms;

namespace ASD.Algorithms.Tests.SortAlgorithms
{
    public class QuickSortTests
    {
        [Fact]
        public void Sort_EmptyArray_DoesNotThrowAndReturnsEmptyArray()
        {
            // Arrange
            int[] input = Array.Empty<int>();

            // Act
            QuickSort.Sort(input);

            // Assert
            Assert.Empty(input);
        }

        [Fact]
        public void Sort_SingleElementArray_DoesNotModifyArray()
        {
            // Arrange
            int[] input = { 42 };

            // Act
            QuickSort.Sort(input);

            // Assert
            Assert.Equal(new[] { 42 }, input);
        }

        [Fact]
        public void Sort_AlreadySortedArray_DoesNotModifyArray()
        {
            // Arrange
            int[] input = { 1, 2, 3, 4, 5 };

            // Act
            QuickSort.Sort(input);

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, input);
        }

        [Fact]
        public void Sort_ReverseSortedArray_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { 5, 4, 3, 2, 1 };

            // Act
            QuickSort.Sort(input);

            // Assert
            Assert.Equal(new[] { 1, 2, 3, 4, 5 }, input);
        }

        [Fact]
        public void Sort_UnsortedArrayWithDuplicates_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { 4, 2, 5, 2, 3, 1, 4 };

            // Act
            QuickSort.Sort(input);

            // Assert
            Assert.Equal(new[] { 1, 2, 2, 3, 4, 4, 5 }, input);
        }

        [Fact]
        public void Sort_ArrayWithNegativeNumbers_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { -3, -1, -2, 0, 2, 1 };

            // Act
            QuickSort.Sort(input);

            // Assert
            Assert.Equal(new[] { -3, -2, -1, 0, 1, 2 }, input);
        }

        [Fact]
        public void Sort_ArrayWithAllEqualElements_DoesNotModifyArray()
        {
            // Arrange
            int[] input = { 7, 7, 7, 7, 7 };

            // Act
            QuickSort.Sort(input);

            // Assert
            Assert.Equal(new[] { 7, 7, 7, 7, 7 }, input);
        }

        [Fact]
        public void Sort_ArrayWithSingleNegativeNumber_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { -1, 0, 1, 2, 3 };

            // Act
            QuickSort.Sort(input);

            // Assert
            Assert.Equal(new[] { -1, 0, 1, 2, 3 }, input);
        }

        [Fact]
        public void Sort_ArrayWithLargeNumbers_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { int.MaxValue, int.MinValue, 0, 100, -100 };

            // Act
            QuickSort.Sort(input);

            // Assert
            Assert.Equal(new[] { int.MinValue, -100, 0, 100, int.MaxValue }, input);
        }

        [Fact]
        public void Sort_ArrayWithTwoElements_SortsArrayCorrectly()
        {
            // Arrange
            int[] input = { 2, 1 };

            // Act
            QuickSort.Sort(input);

            // Assert
            Assert.Equal(new[] { 1, 2 }, input);
        }
    }
}