using CodeChallenge15;
using System;

public class BinarySearchTree<T> : BinaryTree<T> where T : IComparable<T>
{
    public void Add(T value)
    {
        Root = AddNode(Root, value);
    }

    private Node<T> AddNode(Node<T> node, T value)
    {
        if (node == null)
        {
            return new Node<T>(value);
        }

        if (value.CompareTo(node.Value) < 0)
        {
            node.Left = AddNode(node.Left, value);
        }
        else if (value.CompareTo(node.Value) > 0)
        {
            node.Right = AddNode(node.Right, value);
        }

        return node;
    }

    public bool Contains(T value)
    {
        return ContainsValue(Root, value);
    }

    private bool ContainsValue(Node<T> node, T value)
    {
        if (node == null)
        {
            return false;
        }

        if (node.Value.CompareTo(value) == 0)
        {
            return true;
        }
        else if (value.CompareTo(node.Value) < 0)
        {
            return ContainsValue(node.Left, value);
        }
        else
        {
            return ContainsValue(node.Right, value);
        }
    }
}
