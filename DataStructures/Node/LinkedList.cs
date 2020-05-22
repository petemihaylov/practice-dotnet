using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Node
{
    public class LinkedList<Type> : IEnumerable<Type>
    {
        public int Count { get; private set; }
        private Node head;
        private Node tail;


        public void AddFirst(Type item)
        {
            Node oldHead = this.head;
            this.head = new Node(item);

            this.head.Next = oldHead;

            if(this.Count == 0)
            {
                this.tail = this.head;
            }
            this.Count++;
        }

        public void AddLast(Type item)
        {
            Node oldTail = this.tail;

            oldTail.Next = this.tail;

            if(this.Count == 0)
            {
                this.head = this.tail;
            }
            else
            {
                this.tail = new Node(item);
            }
            this.Count++;
        }


        public Type RemoveFirst()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            Node oldhead = this.head;
            this.head = this.head.Next;
            this.Count--;

            if(this.Count == 0)
            {
                this.tail = null;
            }

            return oldhead.Value;
        }
        public Type RemoveLast()
        {
            if(this.Count == 0)
            {
                throw new InvalidOperationException();
            }

            Node oldTail = this.tail;

            if(this.Count == 1)
            {
                this.head = this.tail = null;
            }
            else
            {
                Node newTail = this.GetSecondToLastNode();
                newTail.Next = null;
                this.tail = newTail;
            }
            this.Count--;

            return oldTail.Value;
        }
        private Node GetSecondToLastNode()
        {
            Node current = this.head;

            while(current.Next != this.tail)
            {
                current = current.Next;
            }
            return current;
        }
        public IEnumerator<Type> GetEnumerator()
        {
            Node current = this.head;

            while(current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class Node
        {
            private Type value;
            private Node next; // pointer to the next value

            public Node(Type value)
            {
                this.value = value;
            }

            public Type Value
            {
                get { return this.value; }
                set { this.value = value; }
            }
            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }




        }
    }

}
