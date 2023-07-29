using CodeChallenge15;
using System;

public class BinarySearchTree : BinaryTree
{
    public void Add(int value)
    {
        Root = AddNode(Root, value);
    }

    private Node AddNode(Node node, int value)
    {
        if (node == null)
        {
            return new Node(value);
        }

        if (value < node.Value)
        {
            node.Left = AddNode(node.Left, value);
        }
        else if (value > node.Value)
        {
            node.Right = AddNode(node.Right, value);
        }

        return node;
    }

    public bool Contains(int value)
    {
        return ContainsValue(Root, value);
    }

    private bool ContainsValue(Node node, int value)
    {
        if (node == null)
        {
            return false;
        }

        if (node.Value == value)
        {
            return true;
        }
        else if (value < node.Value)
        {
            return ContainsValue(node.Left, value);
        }
        else
        {
            return ContainsValue(node.Right, value);
        }
    }
}
