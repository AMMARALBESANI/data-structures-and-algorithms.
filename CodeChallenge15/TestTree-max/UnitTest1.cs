using CodeChallenge15;

namespace TestTree_max
{
    public class UnitTest1
    {
        [Fact]
        public void FindTheMaxIfItTheRoot()
        {
            //Arrange
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(25);
            binarySearchTree.Add(3);
            binarySearchTree.Add(7);
            binarySearchTree.Add(2);
            binarySearchTree.Add(4);
            binarySearchTree.Add(6);
            binarySearchTree.Add(8);

            //ACT
            int result = 25;

            //ASSERT

            Assert.Equal(result, binarySearchTree.FindMax());
        }



        [Fact]

        public void FindTheMaxIfItNotTheRoor()
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(5);
            binarySearchTree.Add(3);
            binarySearchTree.Add(7);
            binarySearchTree.Add(25);
            binarySearchTree.Add(4);
            binarySearchTree.Add(6);
            binarySearchTree.Add(8);

            //ACT
            int result = 25;

            //ASSERT

            Assert.Equal(result, binarySearchTree.FindMax());


        }

        [Fact]
        public void treeBreadthFirst()
        {
            BinaryTree tree = new BinaryTree();
            tree.Root = new Node(2);
            tree.Root.Left = new Node(7);
            tree.Root.Right = new Node(5);
            tree.Root.Left.Left = new Node(2);
            tree.Root.Left.Right = new Node(6);
            tree.Root.Left.Right.Left = new Node(5);
            tree.Root.Left.Right.Right = new Node(11);
            tree.Root.Right.Right = new Node(9);
            tree.Root.Right.Right.Left = new Node(4);

            List<int> result = new List<int>() { 2, 7, 5, 2, 6, 9, 5, 11, 4 };

            Assert.Equal(result, tree.TreeBreadthFirst(tree));
        }
    }
}