using CodeChallenge15;
using System;
using System.Collections.Generic;

public class BinaryTree
{
    public Node Root { get; set; }
    public int Max { get; set; }
    public BinaryTree()
    {
        Root = null;
    }

    public List<int> PreOrder()
    {
        List<int> result = new List<int>();
        PreOrderTraversal(Root, result);
        return result;
    }

    public List<int> InOrder()
    {
        List<int> result = new List<int>();
        InOrderTraversal(Root, result);
        return result;
    }

    public List<int> PostOrder()
    {
        List<int> result = new List<int>();
        PostOrderTraversal(Root, result);
        return result;
    }

    private void PreOrderTraversal(Node node, List<int> result)
    {
        if (node != null)
        {
            result.Add(node.Value);
            PreOrderTraversal(node.Left, result);
            PreOrderTraversal(node.Right, result);
        }
    }

    private void InOrderTraversal(Node node, List<int> result)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left, result);
            result.Add(node.Value);
            InOrderTraversal(node.Right, result);
        }
    }

    private void PostOrderTraversal(Node node, List<int> result)
    {
        if (node != null)
        {
            PostOrderTraversal(node.Left, result);
            PostOrderTraversal(node.Right, result);
            result.Add(node.Value);
        }
    }

   public int FindMax()
    {
        
        int temp = 0;
        var x=  PostOrder();
        for (int i = 0; i < x.Count; i++)
        {
            if (temp < x[i])
            {
                temp = x[i];
            }
        }
        return temp;
    }



}
