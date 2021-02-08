using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BinarySearchTreeData
{
    class Tree : ICloneable
    {
        public Node root;
        private string treeOutput;

        public Tree()
        {
            root = null;
        }

        public void Add(int item)
        {
            Node newNode = new Node();
            newNode.value = item;
            if(root == null)
            {
                root = newNode;
                Preorder(root);
            }

            else
            {
                Node currentNode = root;
                Node parent;
                while(true)
                {
                    parent = currentNode;
                    if(item < currentNode.value)
                    {
                        currentNode = currentNode.leftChild;
                        if(currentNode == null)
                        {
                            parent.leftChild = newNode;
                            Preorder(root);
                            return;
                        }
                    }
                    else if(item == currentNode.value)
                    {
                        Preorder(root);
                        return;
                    }
                    else
                    {
                        currentNode = currentNode.rightChild;
                        if(currentNode == null)
                        {
                            parent.rightChild = newNode;
                            Preorder(root);
                            return;
                        }
                    }
                }
            }
        }

        public bool Search(int item)
        {
            Node currentNode = root;
            while (true)
            {
                if (item < currentNode.value)
                {
                    currentNode = currentNode.leftChild;
                    if (currentNode == null)
                    {
                        return false;
                    }
                }

                else if (item > currentNode.value)
                {
                    currentNode = currentNode.rightChild;
                    if (currentNode == null)
                    {
                        return false;
                    }
                }

                else if (item == currentNode.value)
                {
                    return true;
                }
            }
        }

        public void Delete(int item)
        {
            root = DeleteRec(root, item);
        }

        private Node DeleteRec(Node root, int item)
        {
            if(root == null)
            {
                return root;
            }

            if(item < root.value)
            {
                root.leftChild = DeleteRec(root.leftChild, item);
            }

            else if(root.value < item)
            {
                root.rightChild = DeleteRec(root.rightChild, item);
            }

            else
            {
                if(root.leftChild == null)
                {
                    return root.rightChild;
                }
                else if(root.rightChild == null)
                {
                    return root.leftChild;
                }
                root.value = root.leftChild.value;
                root.leftChild = DeleteRec(root.leftChild, root.value);
            }
            return root;
        }

        private void Preorder(Node Root)
        {
            if(Root == null)
            {
                return;
            }

            if(root.value == Root.value)
            {
                treeOutput = "";
            }

            if (Root != null)
            {
                treeOutput += Root.value + " ";
                Preorder(Root.leftChild);
                Preorder(Root.rightChild);
            }
        }

        public override string ToString()
        {
            return treeOutput;
        }

        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }

        public override int GetHashCode()
        {
            return treeOutput.GetHashCode();
        }

        public Node Clone(Node root)
        {
            if(root == null)
            {
                return null;
            }
            Node newNode = new Node();
            newNode.value = root.value;
            newNode.leftChild = Clone(root.leftChild);
            newNode.rightChild = Clone(root.rightChild);
            return newNode;
        }

        public static bool operator ==(Tree firstTree, Tree secondTree)
        {
            return firstTree.Equals(secondTree);
        }

        public static bool operator !=(Tree firstTree, Tree secondTree)
        {
            return !firstTree.Equals(secondTree);
        }
    }
}
