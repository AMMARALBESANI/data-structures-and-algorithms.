using CodeChallenge15;
using System;
using System.Collections.Generic;

public class BinaryTree<T>
{
    public Node<T> Root { get; set; }
    public int Max { get; set; }
    public BinaryTree()
    {
        Root = null;
    }

    public List<T> PreOrder()
    {
        List<T> result = new List<T>();
        PreOrderTraversal(Root, result);
        return result;
    }

    public List<T> InOrder()
    {
        List<T> result = new List<T>();
        InOrderTraversal(Root, result);
        return result;
    }

    public List<T> PostOrder()
    {
        List<T> result = new List<T>();
        PostOrderTraversal(Root, result);
        return result;
    }

    private void PreOrderTraversal(Node<T> node, List<T> result)
    {
        if (node != null)
        {
            result.Add(node.Value);
            PreOrderTraversal(node.Left, result);
            PreOrderTraversal(node.Right, result);
        }
    }

    private void InOrderTraversal(Node<T> node, List<T> result)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left, result);
            result.Add(node.Value);
            InOrderTraversal(node.Right, result);
        }
    }

    private void PostOrderTraversal(Node<T> node, List<T> result)
    {
        if (node != null)
        {
            PostOrderTraversal(node.Left, result);
            PostOrderTraversal(node.Right, result);
            result.Add(node.Value);
        }
    }

   public T FindMax()
    {
        
        T temp = default(T);
        var x=  PostOrder();
        foreach (var num in x)
        {
            if (Comparer<T>.Default.Compare(num,temp)>0)
            {
                temp= num;
            }
        }
        return temp;
    }

    public List<T> TreeBreadthFirst<T>(BinaryTree<T> tree)
    {
        List<T> result = new List<T>();

        if (tree.Root == null)
        {
            return null;
        }

        Queue<Node<T>> queueNodes = new Queue<Node<T>>();

        queueNodes.Enqueue(tree.Root);

        while (queueNodes.Count > 0)
        {
            Node<T> newNode = queueNodes.Peek();

            result.Add(newNode.Value);

            queueNodes.Dequeue();

            if (newNode.Left != null)
            {
                queueNodes.Enqueue(newNode.Left);
            }
            if (newNode.Right != null)
            {
                queueNodes.Enqueue(newNode.Right);
            }
        }

        return result;
    }



}
