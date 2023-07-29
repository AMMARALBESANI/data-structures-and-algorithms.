using Xunit;

public class BinarySearchTreeTests
{
    [Fact]
    public void CanInstantiateEmptyTree()
    {
        BinarySearchTree binarySearchTree = new BinarySearchTree();
        Assert.Null(binarySearchTree.Root);
    }

    [Fact]
    public void CanInstantiateTreeWithSingleNode()
    {
        BinarySearchTree binarySearchTree = new BinarySearchTree();
        binarySearchTree.Add(5);
        Assert.NotNull(binarySearchTree.Root);
        Assert.Equal(5, binarySearchTree.Root.Value);
    }

    [Fact]
    public void CanAddLeftAndRightChildToNode()
    {
        BinarySearchTree binarySearchTree = new BinarySearchTree();
        binarySearchTree.Add(5);
        binarySearchTree.Add(3);
        binarySearchTree.Add(7);
        Assert.NotNull(binarySearchTree.Root.Left);
        Assert.NotNull(binarySearchTree.Root.Right);
        Assert.Equal(3, binarySearchTree.Root.Left.Value);
        Assert.Equal(7, binarySearchTree.Root.Right.Value);
    }

    [Fact]
    public void CanReturnPreOrderTraversal()
    {
        BinarySearchTree binarySearchTree = new BinarySearchTree();
        binarySearchTree.Add(5);
        binarySearchTree.Add(3);
        binarySearchTree.Add(7);
        binarySearchTree.Add(2);
        binarySearchTree.Add(4);
        binarySearchTree.Add(6);
        binarySearchTree.Add(8);

        int[] expectedPreOrder = { 5, 3, 2, 4, 7, 6, 8 };
        Assert.Equal(expectedPreOrder, binarySearchTree.PreOrder());
    }

    [Fact]
    public void CanReturnInOrderTraversal()
    {
        BinarySearchTree binarySearchTree = new BinarySearchTree();
        binarySearchTree.Add(5);
        binarySearchTree.Add(3);
        binarySearchTree.Add(7);
        binarySearchTree.Add(2);
        binarySearchTree.Add(4);
        binarySearchTree.Add(6);
        binarySearchTree.Add(8);

        int[] expectedInOrder = { 2, 3, 4, 5, 6, 7, 8 };
        Assert.Equal(expectedInOrder, binarySearchTree.InOrder());
    }

    [Fact]
    public void CanReturnPostOrderTraversal()
    {
        BinarySearchTree binarySearchTree = new BinarySearchTree();
        binarySearchTree.Add(5);
        binarySearchTree.Add(3);
        binarySearchTree.Add(7);
        binarySearchTree.Add(2);
        binarySearchTree.Add(4);
        binarySearchTree.Add(6);
        binarySearchTree.Add(8);

        int[] expectedPostOrder = { 2, 4, 3, 6, 8, 7, 5 };
        Assert.Equal(expectedPostOrder, binarySearchTree.PostOrder());
    }

    [Fact]
    public void ContainsReturnsTrueForExistingValue()
    {
        BinarySearchTree binarySearchTree = new BinarySearchTree();
        binarySearchTree.Add(5);
        binarySearchTree.Add(3);
        binarySearchTree.Add(7);
        Assert.True(binarySearchTree.Contains(3));
    }

    [Fact]
    public void ContainsReturnsFalseForNonExistingValue()
    {
        BinarySearchTree binarySearchTree = new BinarySearchTree();
        binarySearchTree.Add(5);
        binarySearchTree.Add(3);
        binarySearchTree.Add(7);
        Assert.False(binarySearchTree.Contains(9));
    }
}
