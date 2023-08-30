using Xunit;


public class FizzBuzzTreeTests
{
    [Fact]
    public void FizzBuzz_TransformTree_Success()
    {
        // Arrange: Create a sample k-ary tree
        BinaryTree<int>.KaryTree<int> rootNode = new BinaryTree<int>.KaryTree<int>(15);
        rootNode.Children.Add(new BinaryTree<int>.KaryTree<int>(7));
        rootNode.Children.Add(new BinaryTree<int>.KaryTree<int>(10));
        rootNode.Children[0].Children.Add(new BinaryTree<int>.KaryTree<int>(21));
        rootNode.Children[0].Children.Add(new BinaryTree<int>.KaryTree<int>(9));

        // Act: Apply FizzBuzz transformation
        var fizzBuzzTree = BinaryTree<int>.FizzBuzz(rootNode);

        // Assert: Check the transformed tree values
        Assert.Equal("FizzBuzz", fizzBuzzTree.Value);
        Assert.Equal("7", fizzBuzzTree.Children[0].Value);
        Assert.Equal("Buzz", fizzBuzzTree.Children[1].Value);
        Assert.Equal("Fizz", fizzBuzzTree.Children[0].Children[0].Value);
        Assert.Equal("Fizz", fizzBuzzTree.Children[0].Children[1].Value);

    }
}
