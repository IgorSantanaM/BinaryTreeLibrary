using BinaryTreeLibrary;

public class Tree
{
    private TreeNode root;

    // Constructor
    public Tree()
    {
        root = null;
    }

    // InsertNode method
    public void InsertNode(int insertValue)
    {
        if (root == null)
            root = new TreeNode(insertValue);
        else
            root.Insert(insertValue);
    }

    // PreorderTraversal method
    public void PreorderTraversal()
    {
        PreorderHelper(root);
    }

    // Helper method for preorder traversal
    private void PreorderHelper(TreeNode node)
    {
        if (node != null)
        {
            Console.Write(node.Data + " ");
            PreorderHelper(node.LeftNode);
            PreorderHelper(node.RightNode);
        }
    }

    // InorderTraversal method
    public void InorderTraversal()
    {
        InorderHelper(root);
    }

    // Helper method for inorder traversal
    private void InorderHelper(TreeNode node)
    {
        if (node != null)
        {
            InorderHelper(node.LeftNode);
            Console.Write(node.Data + " ");
            InorderHelper(node.RightNode);
        }
    }

    // PostorderTraversal method
    public void PostorderTraversal()
    {
        PostorderHelper(root);
    }

    // Helper method for postorder traversal
    private void PostorderHelper(TreeNode node)
    {
        if (node != null)
        {
            PostorderHelper(node.LeftNode);
            PostorderHelper(node.RightNode);
            Console.Write(node.Data + " ");
        }
    }
}
