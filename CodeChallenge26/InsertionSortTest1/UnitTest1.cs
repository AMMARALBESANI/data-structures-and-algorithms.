using CodeChallenge26;
namespace InsertionSortTest1
{
    public class UnitTest1
    {
        [Fact]
        public void TestReverseSorted()
        {
            int[] array = { 20, 18, 12, 8, 5, -2 };
            Program.InsertionSort(array);
            int[] expected = { -2, 5, 8, 12, 18, 20 };
            Assert.Equal(expected, array);
        }

        [Fact]
        public void TestFewUniques()
        {
            int[] array = { 5, 12, 7, 5, 5, 7 };
            Program.InsertionSort(array);
            int[] expected = { 5, 5, 5, 7, 7, 12 };
            Assert.Equal(expected, array);
        }

        [Fact]
        public void TestNearlySorted()
        {
            int[] array = { 2, 3, 5, 7, 13, 11 };
            Program.InsertionSort(array);
            int[] expected = { 2, 3, 5, 7, 11, 13 };
            Assert.Equal(expected, array);
        }

    }
}