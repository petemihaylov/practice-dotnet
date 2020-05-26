using System;
using System.Collections.Generic;

namespace BinarySearchTree
{
    public class BinarySearchTree<T> where T : IComparable<T>
    {
        public Node root = null;
        private BinarySearchTree(Node node)
        {
             this.Copy(node);
        }

        private void Copy(Node node)
        {
            if (node == null) return;
            this.Insert(node.Value);
            this.Copy(node.Left);
            this.Copy(node.Right);
        }

        public void Insert(T value)
        {
            // Recursive way 
            //this.root = Insert(this.root, value);


            // Iterative way
            if(this.root == null)
            {
                root = new Node(value);
                return;
            }

            Node parent = null;
            Node current = this.root;

            while(current != null)
            {
                int compare = current.Value.CompareTo(value);

                if(compare > 0)
                {
                    parent = current;
                    current = current.Left;
                }else if(compare < 0)
                {
                    parent = current;
                    current = current.Right;
                }else
                {
                    return;
                }
            }
            Node newNode = new Node(value);
            if (parent.Value.CompareTo(value) > 0)
            {
                parent.Left = newNode;
            }
            else
            {
                parent.Right = newNode;
            }


        }

        // Recursive way
        private Node Insert(Node node, T value)
        {
            if(node == null)
            {
                return new Node(value);
            }

            int compare = node.Value.CompareTo(value);

            if(compare > 0)
            {
                node.Left = this.Insert(node.Left, value);
            }
            else if(compare < 0)
            {
                node.Right = this.Insert(node.Right, value);
            }
            
            return null;
        }

        public bool Contains(T value)
        {
            Node current = this.root;

            while(current != null)
            {
                int compare = current.Value.CompareTo(value);

                if(compare > 0)
                {
                    current = current.Left;
                }else if(compare < 0)
                {
                    current = current.Right;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public BinarySearchTree<T> Search(T item)
        {
            Node current = this.root;

            while(current != null)
            {
                int compare = current.Value.CompareTo(item);

                if(compare > 0)
                {
                    current = current.Left;
                }
                else if(compare < 0)
                {
                    current = current.Right;
                }
                else
                {
                    return new BinarySearchTree<T>(current);
                }
            }
            return new BinarySearchTree<T>(null);
        }

        
        public void EachInOrder(Action<T> action)
        {
            this.EachInOrder(this.root, action);
        }

        private void EachInOrder(Node node, Action<T> action)
        {
            if (node == null) return;

            this.EachInOrder(node.Left, action);
            action(node.Value);
            this.EachInOrder(node.Right, action);
        }


        public class Node
        {
            public T Value { get; set; }

            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(T value)
            {
                this.Value = value;
            }
        }
    }
}
