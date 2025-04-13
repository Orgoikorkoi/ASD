using ASD.Algorithms.SearchAlgorithms;
using System;
using Xunit;

namespace ASD.Algorithms.Tests.SearchAlgorithmsTests
{
    public class BinarySearchTests
    {
        [Fact]
        public void BinSearch_FindsTargetInArray()
        {
            // Arrange
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int key = 7;
            int expectedIndex = 3;

            // Act
            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            // Assert
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void BinSearch_TargetNotInArray_ReturnsMinusOne()
        {
            // Arrange
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int key = 8;

            // Act
            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            // Assert
            Assert.Equal(-1, actualIndex);
        }

        [Fact]
        public void BinSearch_EmptyArray_ReturnsMinusOne()
        {
            // Arrange
            int[] sortedArray = { };
            int key = 7;

            // Act
            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            // Assert
            Assert.Equal(-1, actualIndex);
        }

        [Fact]
        public void BinSearch_SingleElementArray_TargetFound()
        {
            // Arrange
            int[] sortedArray = { 7 };
            int key = 7;
            int expectedIndex = 0;

            // Act
            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            // Assert
            Assert.Equal(expectedIndex, actualIndex);
        }

        [Fact]
        public void BinSearch_SingleElementArray_TargetNotFound()
        {
            // Arrange
            int[] sortedArray = { 7 };
            int key = 8;

            // Act
            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            // Assert
            Assert.Equal(-1, actualIndex);
        }

        [Fact]
        public void BinSearch_LargeArray_TargetFound()
        {
            int[] sortedArray = new int[1_000_000];
            for (int i = 0; i < sortedArray.Length; i++)
                sortedArray[i] = i * 2;

            int key = 1_000_000; // znajduje siê na pozycji 500_000

            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            Assert.Equal(500_000, actualIndex);
        }

        [Fact]
        public void BinSearch_LargeArray_TargetNotFound()
        {
            int[] sortedArray = new int[1_000_000];
            for (int i = 0; i < sortedArray.Length; i++)
                sortedArray[i] = i * 2;

            int key = 1_000_001;

            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            Assert.Equal(-1, actualIndex);
        }

        [Fact]
        public void BinSearch_TargetIsFirstElement()
        {
            int[] sortedArray = { 1, 3, 5, 7, 9 };
            int key = 1;

            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            Assert.Equal(0, actualIndex);
        }

        [Fact]
        public void BinSearch_TargetIsLastElement()
        {
            int[] sortedArray = { 1, 3, 5, 7, 9 };
            int key = 9;

            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            Assert.Equal(4, actualIndex);
        }

        [Fact]
        public void BinSearch_ArrayContainsDuplicates_ReturnsAnyValidIndex()
        {
            int[] sortedArray = { 1, 3, 3, 3, 5 };
            int key = 3;

            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            Assert.True(actualIndex >= 1 && actualIndex <= 3);
        }

        [Fact]
        public void BinSearch_MinIntValue()
        {
            int[] sortedArray = { int.MinValue, -100, 0, 100, int.MaxValue };
            int key = int.MinValue;

            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            Assert.Equal(0, actualIndex);
        }

        [Fact]
        public void BinSearch_MaxIntValue()
        {
            int[] sortedArray = { int.MinValue, -100, 0, 100, int.MaxValue };
            int key = int.MaxValue;

            int actualIndex = BinarySearch.BinSearch(sortedArray, key);

            Assert.Equal(4, actualIndex);
        }
    }
}