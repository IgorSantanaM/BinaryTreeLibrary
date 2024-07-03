## Binary Search Tree

This repository contains a simple implementation of a Binary Search Tree (BST) in C#. The BST is implemented using two classes: `TreeNode` for individual nodes and `Tree` for managing the tree structure.

## TreeNode Class

The `TreeNode` class represents a single node in the binary tree. It contains properties for the node's data (`Data`), left child node (`LeftNode`), and right child node (`RightNode`). The class also includes methods for inserting nodes (`Insert`) recursively.

### Constructor

```csharp
public TreeNode(int nodeData)
{
    Data = nodeData;
    LeftNode = null;
    RightNode = null;
}
```
**Insert Method**
``` csharp
public void Insert(int insertValue)
{
    // Implementation details for inserting a node
    // LeftNode and RightNode are managed based on the comparison of insertValue with Data.
}
``` 
**Tree Class**
The `Tree` class manages the root of the binary search tree (root). It includes methods for inserting nodes (InsertNode) and performing traversals (PreorderTraversal, InorderTraversal, PostorderTraversal).

**Constructor**
``` csharp
public Tree()
{
    root = null;
}
```
**InsertNode Method**
``` csharp
public void InsertNode(int insertValue)
{
    if (root == null)
        root = new TreeNode(insertValue);
    else
        root.Insert(insertValue);
}
```
**Preorder Traversal**
`Preorder traversal` visits the root node first, then recursively visits the left subtree and right subtree.

``` csharp
public void PreorderTraversal()
{
    PreorderHelper(root);
}
```
**Inorder Traversal**
`Inorder traversal` recursively visits the left subtree, visits the root node, then recursively visits the right subtree (results in sorted order for a BST).

``` csharp
public void InorderTraversal()
{
    InorderHelper(root);
}
```
**Postorder Traversal**
`Postorder traversal` recursively visits the left subtree, then the right subtree, and finally the root node.

``` csharp
public void PostorderTraversal()
{
    PostorderHelper(root);
}
```
**TreeTest Class (Testing Example)**
The TreeTest class demonstrates how to use the Tree class by inserting random values into the tree and performing all three types of traversals.
``` csharp
public class TreeTest
{
    public static void Main(string[] args)
    {
        Tree tree = new Tree();
        int insertValue;
        Random random = new Random();

        Console.WriteLine("Inserting values:");
        for (int i = 1; i <= 10; i++)
        {
            insertValue = random.Next(100);
            Console.Write(insertValue + " ");
            tree.InsertNode(insertValue);
        }

        Console.WriteLine("\n\nPreorder traversal:");
        tree.PreorderTraversal();

        Console.WriteLine("\n\nInorder traversal:");
        tree.InorderTraversal();

        Console.WriteLine("\n\nPostorder traversal:");
        tree.PostorderTraversal();

        Console.WriteLine();
    }
}
```
