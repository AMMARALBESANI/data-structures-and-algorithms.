## Trees
this code implement a tree data structure and you can traverse in the tree in three ways:

1-inorder 

2-postorder 

3-preorder

 ## Approach & Efficiency

### Node Class:

The Node class has a simple structure with three properties: Value, Left, and Right. The space complexity for each node is O(1) as it only stores three integer values.

### Binary Tree Class:
The BinaryTree class implements the depth-first traversals 
(pre-order, in-order, and post-order). The time complexity of each traversal is O(N),
where N is the number of nodes in the binary tree. 
This is because we visit each node exactly once during the traversal.
The space complexity is O(N) as well, due to the recursion stack that can hold up to N nodes in the worst case for skewed binary trees.

### Binary Search Tree Class:
The BinarySearchTree class is a subclass of BinaryTree and adds the methods for adding nodes
and checking for the existence of a value. The time complexity of the Add method is O(log N)
on average, and O(N) in the worst case. This is because, in a balanced , 
we traverse the height of the tree, which is log N.
in the worst case when it became a linked list, 
and the time complexity becomes O(N).
The space complexity for the Add method is also O(log N) 
on average and O(N) in the worst case due to the recursion stack.

## whiteboard
![](./lab15wh(2).png)



## solution

![](./solution15.png)
