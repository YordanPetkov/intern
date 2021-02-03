using System;
using System.Collections.Generic;
using System.Text;

namespace _06.BinarySearchTree
{
    public class Node
    {
        public Node()
        {
            Index = -1;
            LeftChild = null;
            RightChild = null;
            Parent = null;
        }

        public int Index { get; set; }
        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public Node Parent { get; set; }

        public void Clone(Node nodeForCloning)
        {
            this.Index = nodeForCloning.Index;
            this.Value = nodeForCloning.Value;
            this.LeftChild = nodeForCloning.LeftChild;
            this.RightChild = nodeForCloning.RightChild;
            this.Parent = nodeForCloning.Parent;
        }
    }
}
