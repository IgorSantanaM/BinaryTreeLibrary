using System;

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
