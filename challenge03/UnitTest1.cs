using Xunit;
using challenge_3;


namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int value = 8;
            

            // Act
            int actualIndex = Program.bisercher(array, value);

            // Assert
            Assert.Equal(7, actualIndex);
        }


        [Fact]

        public void test2()
        {
            int[] array =new int[8] { 2,4,5,6,7,8,5,3};
            int value = 4;

            // Act
            int actualIndex = Program.bisercher(array, value);

            // Assert
            Assert.Equal(1, actualIndex);


        }
    }
}
