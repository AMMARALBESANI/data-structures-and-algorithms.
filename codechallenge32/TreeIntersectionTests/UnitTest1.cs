using codechallenge32;

namespace TreeIntersectionTests
{
    public class UnitTest1
    {
        [Fact]
        public void FindTreeIntersection_Should_Return_Empty_Set_If_No_Common_Values()
        {
            // Arrange
            TreeNode tree1 = new TreeNode(1)
            {
                Left = new TreeNode(2),
                Right = new TreeNode(3)
            };

            TreeNode tree2 = new TreeNode(4)
            {
                Left = new TreeNode(5),
                Right = new TreeNode(6)
            };

            // Act
            HashSet<int> intersection = TreeIntersection.FindTreeIntersection(tree1, tree2);

            // Assert
            Assert.Empty(intersection);
        }

        [Fact]
        public void FindTreeIntersection_Should_Return_Common_Values()
        {
            // Arrange
            TreeNode tree1 = new TreeNode(1)
            {
                Left = new TreeNode(2),
                Right = new TreeNode(3)
            };

            TreeNode tree2 = new TreeNode(2)
            {
                Left = new TreeNode(3),
                Right = new TreeNode(4)
            };

            // Act
            HashSet<int> intersection = TreeIntersection.FindTreeIntersection(tree1, tree2);

            // Assert
            Assert.Collection(intersection,
                value => Assert.Equal(2, value),
                value => Assert.Equal(3, value));
        }

        [Fact]
        public void FindTreeIntersection_Should_Handle_Null_Trees()
        {
            // Arrange
            TreeNode tree1 = null;
            TreeNode tree2 = new TreeNode(1);

            // Act
            HashSet<int> intersection = TreeIntersection.FindTreeIntersection(tree1, tree2);

            // Assert
            Assert.Empty(intersection);
        }
    }
}