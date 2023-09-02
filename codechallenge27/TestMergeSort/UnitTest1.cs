using Xunit;
using CodeChallenge27;
using codechallenge27;

namespace CodeChallenge27.Tests
{
	public class TestMergeSort
	{
		[Theory]
		[InlineData(new[] { 20, 18, 12, 8, 5, -2 }, new[] { -2, 5, 8, 12, 18, 20 })]
		[InlineData(new[] { 5, 12, 7, 5, 5, 7 }, new[] { 5, 5, 5, 7, 7, 12 })]
		[InlineData(new[] { 2, 3, 5, 7, 13, 11 }, new[] { 2, 3, 5, 7, 11, 13 })]
		public void MergeSort_SortsArray(int[] input, int[] expected)
		{
			// Arrange
			MergeSort sorter = new MergeSort();

			// Act
			sorter.Mergesort(input);

			// Assert
			Assert.Equal(expected, input);
		}
	}
}
