using System;

namespace _06.BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            tree.addNode(5);
            tree.addNode(7);
            tree.addNode(2);
            tree.addNode(9);
            tree.addNode(3);
            tree.addNode(8);
            tree.addNode(11);
            tree.addNode(15);
            tree.addNode(1);
            tree.addNode(10);
            Console.WriteLine(tree.searchNode(11));
        }
    }
}
