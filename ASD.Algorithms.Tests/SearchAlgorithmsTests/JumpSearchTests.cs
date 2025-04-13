using ASD.Algorithms.SearchAlgorithms;

namespace ASD.Algorithms.Tests.SearchAlgorithmsTests
{
    public class JumpSearchTests
    {
        [Fact]
        public void Search_KeyFound_ReturnsCorrectIndex()
        {
            // Arrange
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int key = 7;

            // Act
            int index = JumpSearch.Search(sortedArray, key);

            // Assert
            Assert.Equal(3, index);
        }

        [Fact]
        public void Search_KeyNotFound_ReturnsMinusOne()
        {
            // Arrange
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int key = 8;

            // Act
            int index = JumpSearch.Search(sortedArray, key);

            // Assert
            Assert.Equal(-1, index);
        }

        [Fact]
        public void Search_EmptyArray_ReturnsMinusOne()
        {
            // Arrange
            int[] sortedArray = { };
            int key = 7;

            // Act
            int index = JumpSearch.Search(sortedArray, key);

            // Assert
            Assert.Equal(-1, index);
        }

        [Fact]
        public void Search_KeyAtFirstPosition_ReturnsZero()
        {
            // Arrange
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int key = 1;

            // Act
            int index = JumpSearch.Search(sortedArray, key);

            // Assert
            Assert.Equal(0, index);
        }

        [Fact]
        public void Search_KeyAtLastPosition_ReturnsLastIndex()
        {
            // Arrange
            int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13, 15 };
            int key = 15;

            // Act
            int index = JumpSearch.Search(sortedArray, key);

            // Assert
            Assert.Equal(7, index);
        }

        [Fact]
        public void Search_LargeArray_KeyFound()
        {
            int[] sortedArray = new int[1_000_000];
            for (int i = 0; i < sortedArray.Length; i++)
                sortedArray[i] = i;

            int key = 999_999;

            int index = JumpSearch.Search(sortedArray, key);

            Assert.Equal(999_999, index);
        }

        [Fact]
        public void Search_SingleElementArray_KeyFound()
        {
            int[] sortedArray = { 7 };
            int key = 7;

            int index = JumpSearch.Search(sortedArray, key);

            Assert.Equal(0, index);
        }

        [Fact]
        public void Search_SingleElementArray_KeyNotFound()
        {
            int[] sortedArray = { 7 };
            int key = 5;

            int index = JumpSearch.Search(sortedArray, key);

            Assert.Equal(-1, index);
        }

        [Fact]
        public void Search_ArrayWithDuplicates_ReturnsFirstMatch()
        {
            int[] sortedArray = { 1, 3, 3, 3, 5, 7 };
            int key = 3;

            int index = JumpSearch.Search(sortedArray, key);

            // Jump search may return any of the valid indices of duplicates (1, 2, or 3)
            Assert.Contains(index, new[] { 1, 2, 3 });
        }
    }
}