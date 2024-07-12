namespace BinaryTreeLibrary
{
    // TreeNode class definition
    class TreeNode
    {
        public TreeNode LeftNode { get; set; }
        public int Data { get; set; }
        public TreeNode RightNode { get; set; }

        // Constructor
        public TreeNode(int nodeData)
        {
            Data = nodeData;
            LeftNode = null;
            RightNode = null;
        }

        // Insert method
        public void Insert(int insertValue)
        {
            if (insertValue < Data)
            {
                if (LeftNode == null)
                    LeftNode = new TreeNode(insertValue);
                else
                    LeftNode.Insert(insertValue);
            }
            else if (insertValue > Data)
            {
                if (RightNode == null)
                    RightNode = new TreeNode(insertValue);
                else
                    RightNode.Insert(insertValue);
            }
            // Ignore duplicate values (no action needed)
        }
    }
}
