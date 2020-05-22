using System;

namespace Node
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int> firstNode = new Node<int>(5);
            Node<int> secondNode = new Node<int>(10);

            firstNode.Next = secondNode;

            Node<int> currentNode = firstNode;

            while(currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }

        }
    }
}
