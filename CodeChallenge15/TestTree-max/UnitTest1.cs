using Xunit;
using System.Collections.Generic; 
using CodeChallenge15;

namespace TestTree_max
{
    public class UnitTest1
    {
        [Fact]
        public void FindTheMaxIfItTheRoot()
        {
            // Arrange
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Add(25);
            binarySearchTree.Add(3);
            binarySearchTree.Add(7);
            binarySearchTree.Add(2);
            binarySearchTree.Add(4);
            binarySearchTree.Add(6);
            binarySearchTree.Add(8);

            // Act
            var actualMax = binarySearchTree.FindMax();
            int expectedMax = 25;

            // Assert
            Assert.Equal(expectedMax, actualMax);
        }

        [Fact]
        public void FindTheMaxIfItNotTheRoot()
        {
            BinarySearchTree<int> binarySearchTree = new BinarySearchTree<int>();
            binarySearchTree.Add(5);
            binarySearchTree.Add(3);
            binarySearchTree.Add(7);
            binarySearchTree.Add(25);
            binarySearchTree.Add(4);
            binarySearchTree.Add(6);
            binarySearchTree.Add(8);

            // Act
            var actualMax = binarySearchTree.FindMax();
            int expectedMax = 25;

            // Assert
            Assert.Equal(expectedMax, actualMax);
        }

       
    }
}
