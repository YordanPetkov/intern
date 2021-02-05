using System;
using System.Collections.Generic;
using System.Text;

namespace _06.BinarySearchTree
{
    public class BinarySearchTree
    {
        private List<Node> nodes = new List<Node>();
        private Node root = new Node();

        public BinarySearchTree()
        {
            nodes = new List<Node>();
            root = new Node();
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
                Node currentNode = new Node();
                currentNode.Clone(root);
                do
                {
                    if (currentNode.Value >= nodeValue)
                    {
                        currentNode.Clone(currentNode.LeftChild);
                        currentNodeIndex = currentNode.Index;
                    }
                    else if(currentNode.Value < nodeValue)
                    {
                        currentNode.Clone(currentNode.RightChild);
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
            Node currentNode = new Node();
            currentNode.Clone(root);
            do
            {
                Console.WriteLine(currentNode);
                if (currentNode.Value > nodeValue)
                {
                    currentNode.Clone(currentNode.LeftChild);
                }
                else if (currentNode.Value < nodeValue)
                {
                    currentNode.Clone(currentNode.RightChild);
                }
                else if (currentNode.Value == nodeValue)
                {
                    return true;
                }
            } while (currentNode.Index != -1);

            return false;
        }
    }
}
