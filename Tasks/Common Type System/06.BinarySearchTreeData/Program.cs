using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinarySearchTreeData
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(9);
            for (int i = 1; i < 17; i++)
            {
                if(i != 9)
                {
                    tree.Add(i);
                }
            }
            tree.Add(6);
            tree.Delete(6);
            tree.Delete(5);
            Console.WriteLine(tree.ToString());
            Console.WriteLine(tree.Search(7));
            Console.WriteLine(tree.Search(6));
            Console.WriteLine(tree.Search(17));
            Tree tree2 = new Tree();
            Node tempNode = tree.Clone(tree.root);
            tree2.root.value = tempNode.value;
            tree2.root.leftChild = tempNode.leftChild;
            tree2.root.rightChild = tempNode.rightChild;

            Console.WriteLine(tree2.ToString());
            Console.WriteLine(tree.ToString());
        }
    }
}
