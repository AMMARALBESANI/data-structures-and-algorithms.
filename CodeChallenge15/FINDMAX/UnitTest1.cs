using CodeChallenge15;

namespace TreeBreadthFirst
{
    public class UnitTest1
    {
        [Fact]
        public void TreeBreadthFirst()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Root = new Node<int>(2);
            tree.Root.Left = new Node<int>(7);
            tree.Root.Right = new Node<int>(5);
            tree.Root.Left.Left = new Node<int>(2);
            tree.Root.Left.Right = new Node<int>(6);
            tree.Root.Left.Right.Left = new Node<int>(5);
            tree.Root.Left.Right.Right = new Node<int>(11);
            tree.Root.Right.Right = new Node<int>(9);
            tree.Root.Right.Right.Left = new Node<int>(4);

            List<int> result = new List<int>() { 2, 7, 5, 2, 6, 9, 5, 11, 4 };

            Assert.Equal(result, tree.TreeBreadthFirst(tree));
        }
    }
}