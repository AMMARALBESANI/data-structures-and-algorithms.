namespace CodeChallenge15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(5);
            binarySearchTree.Add(3);
            binarySearchTree.Add(7);
            binarySearchTree.Add(2);
            binarySearchTree.Add(4);
            binarySearchTree.Add(6);
            binarySearchTree.Add(8);

            Console.WriteLine("Contains 5: " + binarySearchTree.Contains(5));
            Console.WriteLine("Contains 9: " + binarySearchTree.Contains(9));

        }
    }
}