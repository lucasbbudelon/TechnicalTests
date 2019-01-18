using System;

namespace CountNodesBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Node binaryTree = GetBinaryTree();
            int count = GetNodeCount(binaryTree);
            Console.WriteLine(count.ToString());
        }

        static public Node GetBinaryTree()
        {
            Node node6 = new Node(6);
            Node node3 = new Node(3);
            Node node5 = new Node(5);
            Node node9 = new Node(9);
            Node node2 = new Node(2);
            Node node7 = new Node(7);
            Node node4 = new Node(4);

            node5.Right = node9;
            node3.Left = node5;

            node6.Left = node3;


            node2.Left = node7;
            node2.Right = node4;

            node6.Right = node2;

            return node6;
        }

        static public int GetNodeCount(Node root)
        {
            if (root != null)
            {
                int count = 1;

                count += GetNodeCount(root.Left);
                count += GetNodeCount(root.Right);

                return count;
            }
            else
            {
                return 0;
            }
        }
    }
}
