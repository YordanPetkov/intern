using System;
using System.Collections.Generic;
using System.Text;

namespace _06.BinarySearchTree
{
    class BinarySearchTree
    {
        private List<Node> nodes = new List<Node>();
        private Node root = new Node();
        public BinarySearchTree()
        {
            nodes = new List<Node>();
            root = null;
        }
        public void addNode(int nodeValue)
        {
            if(nodes.Count == 0)
            {
                root.Index = 0;
                root.Parent = null;
                root.LeftChild = null;
                root.RightChild = null;
                root.Value = nodeValue;
                nodes.Add(root);
            }
            else
            {
                int currentNodeIndex = 0;
                Node currentNode = root;
                do
                {
                    if (currentNode.Value >= nodeValue)
                    {
                        currentNode = currentNode.LeftChild;
                        currentNodeIndex = currentNode.Index;
                    }
                    else if(currentNode.Value < nodeValue)
                    {
                        currentNode = currentNode.RightChild;
                        currentNodeIndex = currentNode.Index;
                    }
                } while (currentNode != null);

                Node addedNode = new Node();
                addedNode.Parent = nodes[currentNodeIndex];
                addedNode.Value = nodeValue;
                addedNode.Index = nodes.Count;
                addedNode.RightChild = null;
                addedNode.LeftChild = null;
                nodes.Add(addedNode);

                if (nodes[currentNodeIndex].Value >= nodeValue)
                {
                    nodes[currentNodeIndex].LeftChild = addedNode;
                }
                else if (nodes[currentNodeIndex].Value < nodeValue)
                {
                    nodes[currentNodeIndex].RightChild = addedNode;
                }
            }
        }

        public bool searchNode(int nodeValue)
        {
            Node currentNode = root;
            do
            {
                if (currentNode.Value > nodeValue)
                {
                    currentNode = currentNode.LeftChild;
                }
                else if (currentNode.Value < nodeValue)
                {
                    currentNode = currentNode.RightChild;
                }
                else if (currentNode.Value == nodeValue)
                {
                    return true;
                }
            } while (currentNode != null);

            return false;
        }
    }
}
